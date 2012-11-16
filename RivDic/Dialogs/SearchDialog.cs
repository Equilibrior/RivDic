using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RivDic.Dialogs
{
    /// ============================================================================================================================
    public partial class SearchDialog : Form
    {
        #region Konstruktor

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context">Kontext des Dialoges</param>
        public SearchDialog(string context)
        {
            InitializeComponent();
            LoadData(context);
            fieldsControll.ShowPanel(context);
        }

        #endregion Konstruktor

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lädt die Daten
        /// </summary>
        /// <param name="context">Kontext der Daten zum Laden</param>
        private void LoadData(string context)
        {
            switch (context)
            {
                case Constants.River:
                    {
                        gridView.DataSource = Database.LoadDataTable(Tbl.Fluesse);
                        break;
                    }
                case Constants.Route:
                    {
                        gridView.DataSource = Database.LoadDataTable(Tbl.FlussAbschnitt);
                        break;
                    }
                case Constants.StartEnd:
                    {
                        gridView.DataSource = Database.LoadDataTable(Tbl.StartEnde);
                        break;
                    }
                default:
                    break;
            }
        }

        #endregion Methoden
    }
}
