using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace RivDic
{
    public class Database
    {

        #region Konstanten

        /// <summary> Konstante für den Speicherplatz der Datenbank</summary>
        private const string DbPath = "C:\\Users\\msi\\Databases\\FLUESSEDB.FDB"; //
        /// <summary> Konstante für den User</summary>
        private const string DbUser = "SYSDBA";
        /// <summary> Konstante für das Passwort</summary>
        private const string DbPassword = "masterkey";

        #endregion Konstanten

        #region Methoden

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
            FbConnection fbConnection = new FbConnection(sb.ToString());
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

        #endregion Methoden
    }
}
