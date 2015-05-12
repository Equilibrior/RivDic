using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using RivDic.Dialogs;

namespace RivDic
{
    /// ============================================================================================================================
    public class Database
    {

        #region Properties

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Die Datenbankconnection
        /// </summary>
        private static FbConnection fbConnection { get; set; }

        private static List<KeyValuePair<String, String>> tablesExisting;

        private static List<string> countryList;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste aller Länder zum Füllen der Tabelle
        /// </summary>
        public static List<string> CountryList
        {
            get
            {
                if (countryList == null)
                {
                    countryList = new List<string>();
                    countryList.Add("Afghanistan");
                    countryList.Add("Ägypten");
                    countryList.Add("Albanien");
                    countryList.Add("Algerien");
                    countryList.Add("Andorra");
                    countryList.Add("Angola");
                    countryList.Add("Antarktis");
                    countryList.Add("Antigua und Barbuda");
                    countryList.Add("Äquatorialguinea");
                    countryList.Add("Argentinien");
                    countryList.Add("Armenien");
                    countryList.Add("Aserbaidschan");
                    countryList.Add("Äthiopien");
                    countryList.Add("Australien");
                    countryList.Add("Bahamas");
                    countryList.Add("Bahrain ");
                    countryList.Add("Bangladesch");
                    countryList.Add("Barbados");
                    countryList.Add("Belgien");
                    countryList.Add("Belize");
                    countryList.Add("Benin");
                    countryList.Add("Bhutan");
                    countryList.Add("Bolivien");
                    countryList.Add("Bosnien und Herzegowina");
                    countryList.Add("Botsuana");
                    countryList.Add("Brasilien");
                    countryList.Add("Brunei");
                    countryList.Add("Bulgarien");
                    countryList.Add("Burkina Faso");
                    countryList.Add("Myanmar|Birma");
                    countryList.Add("Burundi");
                    countryList.Add("Chile");
                    countryList.Add("China");
                    countryList.Add("Cookinseln");
                    countryList.Add("Costa Rica");
                    countryList.Add("Dänemark");
                    countryList.Add("Deutschland");
                    countryList.Add("Dominica");
                    countryList.Add("Dominikanische Republik");
                    countryList.Add("Dschibuti");
                    countryList.Add("Ecuador");
                    countryList.Add("Elfenbeinküste");
                    countryList.Add("El Salvador");
                    countryList.Add("Eritrea");
                    countryList.Add("Estland");
                    countryList.Add("Falklandinseln");
                    countryList.Add("Fidschi");
                    countryList.Add("Finnland");
                    countryList.Add("Föderierte Staaten von Mikronesien");
                    countryList.Add("Frankreich");
                    countryList.Add("Französisch Guayana");
                    countryList.Add("Gabun");
                    countryList.Add("Gambia");
                    countryList.Add("Georgien");
                    countryList.Add("Ghana");
                    countryList.Add("Grenada");
                    countryList.Add("Griechenland");
                    countryList.Add("Vereinigtes Königreich|Großbritannien");
                    countryList.Add("Guatemala");
                    countryList.Add("Guinea");
                    countryList.Add("Guinea-Bissau");
                    countryList.Add("Guyana");
                    countryList.Add("Haiti");
                    countryList.Add("Honduras");
                    countryList.Add("Indien");
                    countryList.Add("Indonesien");
                    countryList.Add("Irak");
                    countryList.Add("Iran");
                    countryList.Add("Irland");
                    countryList.Add("Island");
                    countryList.Add("Israel");
                    countryList.Add("Italien");
                    countryList.Add("Jamaika");
                    countryList.Add("Japan");
                    countryList.Add("Jemen");
                    countryList.Add("Jordanien");
                    countryList.Add("Kambodscha");
                    countryList.Add("Kamerun");
                    countryList.Add("Kanada");
                    countryList.Add("Kap Verde");
                    countryList.Add("Kasachstan");
                    countryList.Add("Katar");
                    countryList.Add("Kenia");
                    countryList.Add("Kirgisistan");
                    countryList.Add("Kiribati");
                    countryList.Add("Kolumbien");
                    countryList.Add("Komoren");
                    countryList.Add("Demokratische Republik Kongo|Kongo (Demokratische Republik)");
                    countryList.Add("Republik Kongo|Kongo (Republik)");
                    countryList.Add("Kosovo");
                    countryList.Add("Kroatien");
                    countryList.Add("Kuba");
                    countryList.Add("Kuwait");
                    countryList.Add("Laos");
                    countryList.Add("Lesotho");
                    countryList.Add("Lettland");
                    countryList.Add("Libanon");
                    countryList.Add("Liberia");
                    countryList.Add("Libyen");
                    countryList.Add("Liechtenstein");
                    countryList.Add("Litauen");
                    countryList.Add("Luxemburg");
                    countryList.Add("Madagaskar");
                    countryList.Add("Malawi");
                    countryList.Add("Malaysia");
                    countryList.Add("Malediven");
                    countryList.Add("Mali");
                    countryList.Add("Malta");
                    countryList.Add("Marokko");
                    countryList.Add("Marshallinseln");
                    countryList.Add("Mauretanien");
                    countryList.Add("Mauritius");
                    countryList.Add("Mazedonien");
                    countryList.Add("Mexiko");
                    countryList.Add("Föderierte Staaten von Mikronesien|(Föderierte Staaten von) Mikronesien");
                    countryList.Add("Moldawien");
                    countryList.Add("Monaco");
                    countryList.Add("Mongolei");
                    countryList.Add("Montenegro");
                    countryList.Add("Mosambik");
                    countryList.Add("Myanmar");
                    countryList.Add("Namibia");
                    countryList.Add("Nauru");
                    countryList.Add("Nepal");
                    countryList.Add("Neuseeland");
                    countryList.Add("Nicaragua");
                    countryList.Add("Niederlande");
                    countryList.Add("Niger");
                    countryList.Add("Nigeria");
                    countryList.Add("Nordkorea");
                    countryList.Add("Nordzypern");
                    countryList.Add("Norwegen");
                    countryList.Add("Oman");
                    countryList.Add("Österreich");
                    countryList.Add("Pakistan");
                    countryList.Add("Palau");
                    countryList.Add("Palästina");
                    countryList.Add("Panama");
                    countryList.Add("Papua-Neuguinea");
                    countryList.Add("Paraguay");
                    countryList.Add("Peru");
                    countryList.Add("Philippinen");
                    countryList.Add("Polen");
                    countryList.Add("Portugal");
                    countryList.Add("Ruanda");
                    countryList.Add("Rumänien");
                    countryList.Add("Russland");
                    countryList.Add("Sahara (Staat)|Sahara");
                    countryList.Add("Saint Kitts und Nevis");
                    countryList.Add("Saint Lucia");
                    countryList.Add("Saint Vincent und die Grenadinen");
                    countryList.Add("Salomonen");
                    countryList.Add("Sambia");
                    countryList.Add("Samoa");
                    countryList.Add("San Marino");
                    countryList.Add("São Tomé und Príncipe");
                    countryList.Add("Saudi-Arabien");
                    countryList.Add("Senegal");
                    countryList.Add("Serbien");
                    countryList.Add("Seychellen");
                    countryList.Add("Sierra Leone");
                    countryList.Add("Singapur");
                    countryList.Add("Simbabwe");
                    countryList.Add("Slowakei");
                    countryList.Add("Slowenien");
                    countryList.Add("Somalia");
                    countryList.Add("Spanien");
                    countryList.Add("Sri Lanka");
                    countryList.Add("Südafrika");
                    countryList.Add("Sudan");
                    countryList.Add("Südsudan");
                    countryList.Add("Südkorea");
                    countryList.Add("Surinam");
                    countryList.Add("Svalbard");
                    countryList.Add("Swasiland");
                    countryList.Add("Schweden");
                    countryList.Add("Schweiz");
                    countryList.Add("Syrien");
                    countryList.Add("Tadschikistan");
                    countryList.Add("Taiwan");
                    countryList.Add("Tansania");
                    countryList.Add("Thailand");
                    countryList.Add("Timor-Leste");
                    countryList.Add("Togo");
                    countryList.Add("Tonga");
                    countryList.Add("Trinidad und Tobago");
                    countryList.Add("Tschad");
                    countryList.Add("Tschechien");
                    countryList.Add("Tunesien");
                    countryList.Add("Türkei");
                    countryList.Add("Turkmenistan");
                    countryList.Add("Tuvalu");
                    countryList.Add("Uganda");
                    countryList.Add("Ukraine");
                    countryList.Add("Ungarn");
                    countryList.Add("Uruguay");
                    countryList.Add("Usbekistan");
                    countryList.Add("Vanuatu");
                    countryList.Add("Vatikan");
                    countryList.Add("Venezuela");
                    countryList.Add("Vereinigte Arabische Emirate");
                    countryList.Add("Vereinigtes Königreich");
                    countryList.Add("Vereinigte Staaten von Amerika");
                    countryList.Add("Vietnam");
                    countryList.Add("Weißrussland");
                    countryList.Add("Sahara (Staat)|Westsahara");
                    countryList.Add("Zentralafrikanische Republik");
                    countryList.Add("Zypern");
                }
                return countryList;
            }
        }

        #endregion Properties

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Einlogen in die Datenbank mit Festen User und Passwort 
        /// </summary>
        /// <returns>Hat das Login geklappt</returns>
        public static LoginResult DatabaseLogin()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User = " + ReadSettings(Constants.DbUser) + "; ");
            sb.Append("Password = " + ReadSettings(Constants.DbPassword) + "; ");
            sb.Append("Database = " + ReadSettings(Constants.DbPath) + "; ");
            sb.Append("DataSource = localhost; ");
            sb.Append("Dialect = 3; ");
            sb.Append("Charset = NONE; ");
            sb.Append("Port = 3050;");
            try
            {
                fbConnection = new FbConnection(sb.ToString());
                fbConnection.Open();
                ReorgDatabase();
                return LoginResult.Successfull;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to complete network request"))
                {
                    return LoginResult.FirebirdNotStarted;
                }
                if (ex.Message.Contains("I/O error during \"CreateFile (open)\" operation for file"))
                {
                    return LoginResult.DatabaseNotFound;
                }
                if (ex.Message.Contains("Your user name and password are not defined."))
                {
                    return LoginResult.LoginDataIncorrect;
                }
                if (ex.Message.Contains("An invalid connection string argument has been supplied"))
                {
                    return LoginResult.ConnectionStringArgumentError;
                }
                return LoginResult.Error;
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lädt alle Daten der übergebenen Tabelle 
        /// </summary>
        /// <param name="tableName">Tabelle die geladen werden soll</param>
        /// <returns>Der Inhalt der Tabelle als DataTable</returns>
        public static DataTable LoadDataTable(String tableName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM ");
            sb.Append(tableName.ToUpper());
            DataTable dt = ExecuteQuery(sb.ToString());
            return dt;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Speichert das übergebene Dictionary in die Tabelle
        /// </summary>
        /// <param name="tableName">Name der Tabelle in die gespeichert werden soll</param>
        /// <param name="dict">Die Werte die gespeichert, werden sollen</param>
        /// <returns>True, falls das Speichern geklappt hat</returns>
        public static Boolean SaveData(String tableName, Dictionary<string, object> dict)
        {
            if (dict.Count <= 0)
                return false;
            string sql = string.Empty;
            if (CheckIdExists(tableName, dict[Fld.Id]))
                sql = BuildUpdateCommand(tableName, dict).ToString();
            else
                sql = BuildSaveCommand(tableName, dict).ToString();
            DataTable dt = Database.ExecuteQuery(sql);
            return true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Prüft ob ein Reorg der Datenbank nötig ist.
        /// </summary>
        /// <returns></returns>
        private static void CheckReorgNeed()
        {
            string sql = "SELECT * FROM RDB$RELATIONS";
            DataTable dt = ExecuteQuery(sql);
            tablesExisting = new List<KeyValuePair<String, String>>();
            foreach (DataRow row in dt.Rows)
            {
                if (row[8].ToString().Trim().Equals(Tbl.Fluesse))
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.Fluesse, Boolean.TrueString));
                else
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.Fluesse, Boolean.FalseString));

                if (row[8].ToString().Trim().Equals(Tbl.FlussAbschnitt))
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.FlussAbschnitt, Boolean.TrueString));
                else
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.FlussAbschnitt, Boolean.FalseString));

                if (row[8].ToString().Trim().Equals(Tbl.Laender))
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.Laender, Boolean.TrueString));
                else
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.Laender, Boolean.FalseString));

                if (row[8].ToString().Trim().Equals(Tbl.StartEnde))
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.StartEnde, Boolean.TrueString));
                else
                    tablesExisting.Add(new KeyValuePair<String, String>(Tbl.StartEnde, Boolean.FalseString));
            }


        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reoganisiert die Datenbank
        /// </summary>
        private static void ReorgDatabase()
        {
            CheckReorgNeed();
            CreateTables();
            AlterTables();
            FillCountryTable();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Erzeugt die Tabellen mit Feldern und Primär
        /// </summary>
        private static void CreateTables()
        {
            if (tablesExisting[0].Value == Boolean.FalseString)
            {
                //CREATE TABLE FLUESSE
                //(
                //"ID" VARCHAR(255) NOT NULL,
                //"WWLEVEL" VARCHAR(255) NOT NULL,
                //"NAME" VARCHAR(255) NOT NULL,
                //"TICKET" Boolean NOT NULL,
                //"TICKETPREIS" DECIMAL(2,2),
                //"DATAEND" TIMESTAMP,
                //CONSTRAINT "PK_FLUESSE" PRIMARY KEY ("ID")
                //)
                StringBuilder createTableFluesseSql = new StringBuilder("CREATE TABLE \"" + Tbl.Fluesse + "\"");
                createTableFluesseSql.AppendLine("(\"" + Fld.Id + "\" VARCHAR(255)  NOT NULL,");
                createTableFluesseSql.AppendLine("\"" + Fld.WWLevel + "\" VARCHAR(3) NOT NULL,");
                createTableFluesseSql.AppendLine("\"" + Fld.Name + "\" VARCHAR(255) NOT NULL,");
                createTableFluesseSql.AppendLine("\"" + Fld.Land + "\" VARCHAR(255) NOT NULL,");
                createTableFluesseSql.AppendLine("\"" + Fld.Ticket + "\" CHAR(1) NOT NULL,");
                createTableFluesseSql.AppendLine("\"" + Fld.Ticketpreis + "\" DECIMAL(2,2),");
                createTableFluesseSql.AppendLine("\"" + Fld.DatAend + "\" TIMESTAMP,");
                createTableFluesseSql.AppendLine("CONSTRAINT \"PK_" + Tbl.Fluesse + "\" PRIMARY KEY (\"" + Fld.Id + "\"));");
                ExecuteQuery(createTableFluesseSql.ToString());
            }

            if (tablesExisting[1].Value == Boolean.FalseString)
            {
                //CREATE TABLE FLUSSABSCHNITT
                //(
                //"ID" VARCHAR(255) NOT NULL,
                //"FLUSSID" VARCHAR(255) NOT NULL,
                //"NAME" VARCHAR(255) NOT NULL,
                //"WWLEVEL" VARCHAR(3),
                //"EINSETZPUNKT" VARCHAR(255),
                //"AUSSETZPUNKT" VARCHAR(255),
                //"KOMMENTAR" VARCHAR(255),
                //"DATAEND" TIMESTAMP,
                //CONSTRAINT "PK_FLUSSABSCHNITT" PRIMARY KEY ("ID")
                //),
                StringBuilder createTableFlussAbschnittSql = new StringBuilder("CREATE TABLE \"" + Tbl.FlussAbschnitt + "\"");
                createTableFlussAbschnittSql.AppendLine("(\"" + Fld.Id + "\" VARCHAR(255)  NOT NULL,");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.FlussId + "\" VARCHAR(255) NOT NULL,");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.Name + "\" VARCHAR(255) NOT NULL,");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.WWLevel + "\" VARCHAR(3),");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.Einsetzpunkt + "\" VARCHAR(255),");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.Aussetzpunkt + "\" VARCHAR(255),");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.Kommentar + "\" VARCHAR(255),");
                createTableFlussAbschnittSql.AppendLine("\"" + Fld.DatAend + "\" TIMESTAMP,");
                createTableFlussAbschnittSql.AppendLine("CONSTRAINT \"PK_ " + Tbl.FlussAbschnitt + "\" PRIMARY KEY (\"" + Fld.Id + "\"));");
                ExecuteQuery(createTableFlussAbschnittSql.ToString());
            }

            if (tablesExisting[2].Value == Boolean.FalseString)
            {
                //CREATE TABLE "LAENDER"
                //(
                // "ID"     String 255  NOT NULL,
                // "NAME"     String 255  NOT NULL,
                //CONSTRAINT "PK_LAENDER" PRIMARY KEY ("ID")
                //);
                StringBuilder createTableLaenderSql = new StringBuilder("CREATE TABLE \"" + Tbl.Laender + "\"");
                createTableLaenderSql.AppendLine("(\"" + Fld.Id + "\" VARCHAR(255)  NOT NULL,");
                createTableLaenderSql.AppendLine("\"" + Fld.Name + "\" VARCHAR(255) NOT NULL,");
                createTableLaenderSql.AppendLine("CONSTRAINT \"PK_" + Tbl.Laender + "\" PRIMARY KEY (\"" + Fld.Id + "\"));");
                ExecuteQuery(createTableLaenderSql.ToString());
            }

            if (tablesExisting[3].Value == Boolean.FalseString)
            {
                //CREATE TABLE "STARTENDE"
                //(
                // "ID"     String 255  NOT NULL,
                // "NAME"     String 255  NOT NULL,
                // "LAND"     String 255 ,
                // "KOORDINATEN"     String 255  NOT NULL,
                // "EINSTIEG"     Boolean ,
                // "AUSSTIEG"     Boolean ,
                // "DATAEND"     TIMESTAMP,
                //CONSTRAINT "PK_STARTENDE" PRIMARY KEY ("ID")
                //);
                StringBuilder createTableStartEndeSql = new StringBuilder("CREATE TABLE \"" + Tbl.StartEnde + "\"");
                createTableStartEndeSql.AppendLine("(\"" + Fld.Id + "\" VARCHAR(255)  NOT NULL,");
                createTableStartEndeSql.AppendLine("\"" + Fld.Name + "\" VARCHAR(255) NOT NULL,");
                createTableStartEndeSql.AppendLine("\"" + Fld.Land + "\" VARCHAR(255) NOT NULL,");
                createTableStartEndeSql.AppendLine("\"" + Fld.Koordinaten + "\" VARCHAR(255) NOT NULL,");
                createTableStartEndeSql.AppendLine("\"" + Fld.Einsetzpunkt + "\" CHAR(1) NOT NULL,");
                createTableStartEndeSql.AppendLine("\"" + Fld.Aussetzpunkt + "\" CHAR(1) NOT NULL,");
                createTableStartEndeSql.AppendLine("\"" + Fld.DatAend + "\" TIMESTAMP,");
                createTableStartEndeSql.AppendLine("CONSTRAINT \"PK_" + Tbl.StartEnde + "\" PRIMARY KEY (\"" + Fld.Id + "\"));");
                ExecuteQuery(createTableStartEndeSql.ToString());
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ergänzt die Fremdschlüssel
        /// </summary>
        private static void AlterTables()
        {
            //ALTER TABLE "FLUSSABSCHNITT" ADD CONSTRAINT "FK_FLUSSABSCHNITT_1" FOREIGN KEY ("EINSETZPUNKT") REFERENCES "STARTENDE" ("ID") ON UPDATE CASCADE ON DELETE NO ACTION;
            StringBuilder addFK1TableFlussAbschnittSql = new StringBuilder("ALTER TABLE " + Tbl.FlussAbschnitt + " ");
            addFK1TableFlussAbschnittSql.Append("ADD CONSTRAINT FK_" + Tbl.FlussAbschnitt + "_1 ");
            addFK1TableFlussAbschnittSql.Append("FOREIGN KEY (" + Fld.Einsetzpunkt + " ) ");
            addFK1TableFlussAbschnittSql.Append("REFERENCES " + Tbl.StartEnde + " ( " + Fld.Id + ") ");
            addFK1TableFlussAbschnittSql.Append("ON UPDATE CASCADE ON DELETE NO ACTION;");
            ExecuteQuery(addFK1TableFlussAbschnittSql.ToString());

            //ALTER TABLE "FLUSSABSCHNITT" ADD CONSTRAINT "FK_FLUSSABSCHNITT_2" FOREIGN KEY ("AUSSETZPUNKT") REFERENCES "STARTENDE" ("ID") ON UPDATE CASCADE ON DELETE NO ACTION;
            StringBuilder addFK2TableFlussAbschnittSql = new StringBuilder("ALTER TABLE " + Tbl.FlussAbschnitt + " ");
            addFK2TableFlussAbschnittSql.Append("ADD CONSTRAINT FK_" + Tbl.FlussAbschnitt + "_2 ");
            addFK2TableFlussAbschnittSql.Append("FOREIGN KEY (" + Fld.Aussetzpunkt + " ) ");
            addFK2TableFlussAbschnittSql.Append("REFERENCES " + Tbl.StartEnde + " ( " + Fld.Id + ") ");
            addFK2TableFlussAbschnittSql.Append("ON UPDATE CASCADE ON DELETE NO ACTION;");
            ExecuteQuery(addFK2TableFlussAbschnittSql.ToString());

            //ALTER TABLE "FLUSSABSCHNITT" ADD CONSTRAINT "FK_FLUSSABSCHNITT_3" FOREIGN KEY ("FLUSSID") REFERENCES "FLUESSE" ("ID") ON UPDATE CASCADE ON DELETE NO ACTION;
            StringBuilder addFK3TableFlussAbschnittSql = new StringBuilder("ALTER TABLE " + Tbl.FlussAbschnitt + " ");
            addFK3TableFlussAbschnittSql.Append("ADD CONSTRAINT FK_" + Tbl.FlussAbschnitt + "_3 ");
            addFK3TableFlussAbschnittSql.Append("FOREIGN KEY (" + Fld.FlussId + " ) ");
            addFK3TableFlussAbschnittSql.Append("REFERENCES " + Tbl.Fluesse + " ( " + Fld.Id + ") ");
            addFK3TableFlussAbschnittSql.Append("ON UPDATE CASCADE ON DELETE NO ACTION;");
            ExecuteQuery(addFK3TableFlussAbschnittSql.ToString());
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Füllt die Tabelle LAENDER mit Daten
        /// </summary>
        private static void FillCountryTable()
        {

            DataTable dt = ExecuteQuery("SELECT COUNT(*) FROM " + Tbl.Laender);
            if (Convert.ToInt64(dt.Rows[0].ItemArray[0]) > 0)
            {
                //Tabelle hat Inhalte keine Änderung Notwendig
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                //sb.Append(Tbl.Laender);
                //sb.Append(" VALUES ");
                sb.AppendLine("EXECUTE BLOCK AS BEGIN");
                foreach (String country in CountryList)
                {
                    sb.Append("INSERT INTO " + Tbl.Laender);
                    sb.Append(" VALUES ('" + Guid.NewGuid() + "', '");
                    sb.AppendLine(country + "');");
                }
                sb.AppendLine("END");
                ExecuteQuery(sb.ToString());
            }
        }

        #region Hilfsmethoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Prüft ob die angegebene ID schon in dieser Tabelle existiert.
        /// </summary>
        /// <param name="tableName">Tabelle die überprüft werden soll.</param>
        /// <param name="id">Id die überprüft werden soll.</param>
        /// <returns>True, falls die Id schon existiert. False, wenn nicht.</returns>
        private static Boolean CheckIdExists(string tableName, object id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT COUNT(*) FROM " + tableName);
            sb.Append(" WHERE " + Fld.Id + "='" + id + "'");
            DataTable dt = ExecuteQuery(sb.ToString());
            if (dt.Rows[0].ItemArray[0].Equals(0))
                return false;
            return true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Führt das übegenen SQL Kommando aus
        /// </summary>
        /// <param name="sql">SQL Befehl der ausgeführt werden soll</param>
        /// <returns>Die Ergebnismenge des Befehls</returns>
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
        /// <param name="dict">Dictionary aus Strings, Object Paaren mit den Daten</param>
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

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Erstellt das Kommando zum Updaten der Daten in die jeweilige Tabelle
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dict">Dictionary aus Strings, Object Paaren mit den Daten</param>
        /// <returns>Das Kommando</returns>
        private static StringBuilder BuildUpdateCommand(String tableName, Dictionary<string, object> dict)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE ");
            sb.Append(tableName);
            sb.Append(" SET " + Fld.Id + "=");
            sb.Append("'" + dict[Fld.Id] + "', ");
            switch (tableName)
            {
                case Tbl.Fluesse:
                default:
                    {
                        sb.Append(Fld.WWLevel + "=");
                        sb.Append("'" + dict[Fld.WWLevel] + "', ");
                        sb.Append(Fld.Name + "=");
                        sb.Append("'" + dict[Fld.Name] + "', ");
                        sb.Append(Fld.Ticket + "=");
                        sb.Append("'" + dict[Fld.Ticket] + "', ");
                        sb.Append(Fld.Ticketpreis + "=");
                        sb.Append("'" + dict[Fld.Ticketpreis] + "', ");
                        sb.Append(Fld.DatAend + "=");
                        sb.Append("'" + DateTime.Now + "'");
                        break;
                    }
                case Tbl.FlussAbschnitt:
                    {
                        sb.Append(Fld.FlussId + "=");
                        sb.Append("'" + dict[Fld.FlussId] + "', ");
                        sb.Append(Fld.WWLevel + "=");
                        sb.Append("'" + dict[Fld.WWLevel] + "', ");
                        sb.Append(Fld.Einsetzpunkt + "=");
                        sb.Append("'" + dict[Fld.Einsetzpunkt] + "', ");
                        sb.Append(Fld.Aussetzpunkt + "=");
                        sb.Append("'" + dict[Fld.Aussetzpunkt] + "', ");
                        sb.Append(Fld.Kommentar + "=");
                        sb.Append("'" + dict[Fld.Kommentar] + "', ");
                        sb.Append(Fld.DatAend + "=");
                        sb.Append("'" + DateTime.Now + "', ");
                        sb.Append(Fld.Name + "=");
                        sb.Append("'" + dict[Fld.Name] + "'");
                        break;
                    }
                case Tbl.StartEnde:
                    {
                        sb.Append(Fld.Name + "=");
                        sb.Append("'" + dict[Fld.Name] + "', ");
                        sb.Append(Fld.Land + "=");
                        sb.Append("'" + dict[Fld.Land] + "', ");
                        sb.Append(Fld.Koordinaten + "=");
                        sb.Append("'" + dict[Fld.Koordinaten] + "', ");
                        sb.Append(Fld.Einsetzpunkt + "=");
                        sb.Append("'" + dict[Fld.Einsetzpunkt] + "', ");
                        sb.Append(Fld.Aussetzpunkt + "=");
                        sb.Append("'" + dict[Fld.Aussetzpunkt] + "', ");
                        sb.Append(Fld.DatAend + "=");
                        sb.Append("'" + DateTime.Now + "'");
                        break;
                    }
            }
            sb.Append(" WHERE " + Fld.Id + "='" + dict[Fld.Id] + "'");
            return sb;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Filter die Einträge der übergebenen Tabelle anhand des übergegeben Dictionaries
        /// </summary>
        /// <param name="tableName">Tabelle die gefiltert werden soll</param>
        /// <param name="dict">Dictionary mit den Werten die gefiltert werden sollen</param>
        /// <returns>DataTable mit den gefilterten Werten</returns>
        public static DataTable FilterData(String tableName, Dictionary<string, string> dict)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM " + tableName);
            sb.Append(" WHERE ");
            int index = 0;
            foreach (string field in dict.Keys)
            {
                sb.Append(field + " = " + dict[field]);
                if (index < dict.Count)
                    sb.Append(" OR ");
            }
            DataTable dt = ExecuteQuery(sb.ToString());
            return dt;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Schreibt die übergebenen Werte in die Settings
        /// </summary>
        /// <param name="section">Section unter der der Wert gespeichert werden soll, Einzigartig</param>
        /// <param name="value">Wert der gespeichert werden soll</param>
        public static void WriteSettings(String section, String value)
        {
            if (section.Equals(Constants.DbUser))
                Properties.Settings.Default.DatabaseUser = value;
            if (section.Equals(Constants.DbPassword))
                Properties.Settings.Default.DatabasePassword = value;
            if (section.Equals(Constants.DbPath))
                Properties.Settings.Default.DatabasePath = value;

            Properties.Settings.Default.Save();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liest den Wert aus der übergebenen Section
        /// </summary>
        /// <param name="section">Section die gelesen werden soll</param>
        /// <returns>Den der Wert der Section oder String.Empty</returns>
        public static String ReadSettings(String section)
        {
            if (section.Equals(Constants.DbUser))
                return Properties.Settings.Default.DatabaseUser;
            if (section.Equals(Constants.DbPassword))
                return Properties.Settings.Default.DatabasePassword;
            if (section.Equals(Constants.DbPath))
                return Properties.Settings.Default.DatabasePath;

            return string.Empty;
        }

        #endregion Hilfsmethoden

        #endregion Methoden

    }

    /// ============================================================================================================================
    /// <summary>
    /// Enum Klasse um das Resultat der Loginmethode wiederzugeben
    /// </summary>
    public enum LoginResult
    {
        /// <summary>Firebirddienst ist nicht gestartet</summary>
        FirebirdNotStarted = 0,
        /// <summary>Datenbank wurde nicht gefunden</summary>
        DatabaseNotFound = 1,
        /// <summary>Die Logindaten stimmen nicht mit der Datenbank überein</summary>
        LoginDataIncorrect = 2,
        /// <summary>Login wurde erfolgreich ausgeführt</summary>
        Successfull = 3,
        /// <summary>Ein Argument des Connection Strings wurde falsch angegeben</summary>
        ConnectionStringArgumentError = 4,
        /// <summary>Sonstiger Fehler</summary>
        Error = 10,
    }

}
