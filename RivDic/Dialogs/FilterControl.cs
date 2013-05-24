using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RivDic.Dialogs
{
    /// ============================================================================================================================
    public partial class FilterControl : UserControl
    {
        #region Konstruktor
        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        public FilterControl()
        {
            InitializeComponent();
        }

        #endregion Konstruktor

        #region Properties

        private string tableName;

        #endregion Properties

        #region Methoden
        
        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Rückt das aktuelle Panel an erste Stelle
        /// </summary>
        /// <param name="context">Kontext des Panels</param>
        /// <remarks>Muss beim Anzeigen des Controlls immer aufgerufen werden 
        /// um ein Panel in den Sichtbereich zu rücken</remarks>
        public void ShowPanel(string context)
        {
            switch (context)
            {
                case Constants.River:
                    {
                        pnlRiver.Location = new Point(0, 0);
                        tableName = Tbl.Fluesse;
                        break;
                    }
                case Constants.Route:
                    {
                        pnlRoute.Location = new Point(0, 0);
                        tableName = Tbl.FlussAbschnitt;
                        DataTable dt = Database.LoadDataTable(Tbl.Fluesse);
                        foreach (DataRow row in dt.Rows)
                        {
                            IdLabelItem idlItem = new IdLabelItem(row[Fld.Id].ToString(), row[Fld.Name].ToString());
                            cbxRouteRiver.Items.Add(idlItem);
                        }
                        dt.Clear();
                        dt = Database.LoadDataTable(Tbl.StartEnde);
                        foreach (DataRow row in dt.Rows)
                        {
                            IdLabelItem idlItem = new IdLabelItem(row[Fld.Id].ToString(), row[Fld.Name].ToString());
                            cbxRouteStart.Items.Add(idlItem);
                            cbxRouteEnd.Items.Add(idlItem);
                        }
                        break;
                    }
                case Constants.StartEnd:
                    {
                        pnlStartEnd.Location = new Point(0, 0);
                        tableName = Tbl.StartEnde;
                        break;
                    }
                default:
                    break;
            }
        }

        public Dictionary<string, string> GetFilterDict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (!String.IsNullOrEmpty(txtRiverName.Text))
                dict.Add(Fld.Name, txtRiverName.Text);
            if (!string.IsNullOrEmpty(txtRiverLand.Text))
                dict.Add(Fld.Land, txtRiverLand.Text);
            dict.Add(Fld.Ticket, chkRiverTicket.Checked.ToString());
            if (string.IsNullOrEmpty(txtRiverTicketPrice.Text))
                dict.Add(Fld.Ticketpreis, txtRiverTicketPrice.Text);
            if (string.IsNullOrEmpty(txtRiverWWLevel.Text))
                dict.Add(Fld.WWLevel, txtRiverWWLevel.Text);

            return dict;
        }
        
        #endregion Methoden

    }
}
