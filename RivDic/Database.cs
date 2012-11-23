using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace RivDic
{
    /// ============================================================================================================================
    public class Database
    {

        #region Konstanten

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary> Konstante für den Speicherplatz der Datenbank</summary>
        private const string DbPath = "C:\\Users\\msi\\Databases\\FLUESSEDB.FDB"; //
        /// <summary> Konstante für den User</summary>
        private const string DbUser = "SYSDBA";
        /// <summary> Konstante für das Passwort</summary>
        private const string DbPassword = "masterkey";

        #endregion Konstanten

        #region Properties

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Die Datenbankconnection
        /// </summary>
        private static FbConnection fbConnection { get; set; }

        #endregion Properties

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Einlogen in die Datenbank mit Festen User und Passwort 
        /// </summary>
        /// <returns>Hat das Login geklappt</returns>
        public static Boolean DatabaseLogin()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User = " + DbUser + "; ");
            sb.Append("Password = " + DbPassword + "; ");
            sb.Append("Database = " + DbPath + "; ");
            sb.Append("DataSource = localhost; ");
            sb.Append("Dialect = 3; ");
            sb.Append("Charset = NONE; ");
            sb.Append("Port = 3050;");
            fbConnection = new FbConnection(sb.ToString());
#if DEBUG
            fbConnection.Open();
            return true;

#else
            try
            {
                fbConnection.Open();
                return true;
            }
            catch (FbException)
            {
                StringBuilder text = new StringBuilder();
                text.Append("Das Programm kann nicht gestartet werden da das Einloggen auf die Datenbank \"");
                text.Append(DbPath);
                text.Append("\" einen Fehler verursacht hat.");
                System.Windows.Forms.MessageBox.Show(text.ToString(), "Datenbankfehler", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
#endif
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lädt alle Daten der übergebenen Tabelle 
        /// </summary>
        /// <param name="tableName">Tabelle die geladen werden soll</param>
        /// <returns>Der Inhalt der Tabelle als DataTable</returns>
        public static DataTable LoadDataTable(String tableName)
        {
            DataTable dt = new DataTable();

            FbTransaction fbTransaction = fbConnection.BeginTransaction();

            FbCommand fbCommand = new FbCommand();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM ");
            sb.Append(tableName.ToUpper());

            fbCommand.CommandText = sb.ToString();
            fbCommand.Connection = fbConnection;
            fbCommand.Transaction = fbTransaction;

            FbDataAdapter fbAdapter = new FbDataAdapter(fbCommand);
            fbAdapter.Fill(dt);

            fbTransaction.Dispose();
            fbCommand.Dispose();
            fbAdapter.Dispose();

            return dt;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dict"></param>
        /// <returns>True, falls das speicher geklappt hat</returns>
        public static Boolean SaveData(String tableName, Dictionary<string, object> dict)
        {
            FbCommand fbCommand = new FbCommand();
            FbTransaction fbTransaction = fbConnection.BeginTransaction();

            fbCommand.CommandText = BuildSaveCommand(tableName, dict).ToString();
            fbCommand.Connection = fbConnection;
            fbCommand.Transaction = fbTransaction;
#if DEBUG
            fbCommand.ExecuteNonQuery();
            fbTransaction.Commit();
#else
            try
            {
                fbCommand.ExecuteNonQuery();
                fbTransaction.Commit();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                fbTransaction.Dispose();
                fbCommand.Dispose();
            }
#endif
            return true;


        }

        public static DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();

            FbTransaction fbTransaction = fbConnection.BeginTransaction();

            FbCommand fbCommand = new FbCommand();

            fbCommand.CommandText = sql;
            fbCommand.Connection = fbConnection;
            fbCommand.Transaction = fbTransaction;

            FbDataAdapter fbAdapter = new FbDataAdapter(fbCommand);
            fbAdapter.Fill(dt);
            fbTransaction.Commit();
            fbTransaction.Dispose();
            fbCommand.Dispose();
            fbAdapter.Dispose();

            return dt;
        }

        /// ------------------------------------------------------------------------------------------------------------------------        
        /// <summary>
        /// Erstellt das Kommando zum Speichern der Daten in die jeweilige Tabelle
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dict"></param>
        /// <returns>Das Kommando</returns>
        private static StringBuilder BuildSaveCommand(String tableName, Dictionary<string, object> dict)
        {
            switch (tableName)
            {
                case Tbl.Fluesse:
                default:
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("INSERT INTO ");
                        sb.Append(tableName);
                        sb.Append(" VALUES('" + dict[Fld.Id] + "', '");
                        sb.Append(dict[Fld.WWLevel] + "', '");
                        sb.Append(dict[Fld.Name] + "', '");
                        sb.Append(dict[Fld.Land] + "', '");
                        sb.Append(dict[Fld.Ticket] + "', '");
                        sb.Append(dict[Fld.Ticketpreis] + "', '");
                        sb.Append(DateTime.Now + "')");
                        return sb;
                    }
                case Tbl.FlussAbschnitt:
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("INSERT INTO ");
                        sb.Append(tableName);
                        sb.Append(" VALUES('" + dict[Fld.Id] + "', '");
                        sb.Append(dict[Fld.FlussId] + "', '");
                        sb.Append(dict[Fld.WWLevel] + "', '");
                        sb.Append(dict[Fld.Einsetzpunkt] + "', '"); //Boolean
                        sb.Append(dict[Fld.Aussetzpunkt] + "', '"); //Boolean
                        sb.Append(dict[Fld.Kommentar] + "', '");
                        sb.Append(DateTime.Now + "', '");
                        sb.Append(dict[Fld.Name] + "')");
                        return sb;
                    }
                case Tbl.StartEnde:
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("INSERT INTO ");
                        sb.Append(tableName);
                        sb.Append(" VALUES('" + dict[Fld.Id] + "', '");
                        sb.Append(dict[Fld.Name] + "', '");
                        sb.Append(dict[Fld.Land] + "', '");
                        sb.Append(dict[Fld.Koordinaten] + "', '");
                        sb.Append(dict[Fld.Einsetzpunkt] + "', '"); //Koordinaten
                        sb.Append(dict[Fld.Aussetzpunkt] + "', '"); //Koordinaten
                        sb.Append(DateTime.Now + "')");

                        return sb;
                    }
            }

        }

       

        #endregion Methoden
    }
}
