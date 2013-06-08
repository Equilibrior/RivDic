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
                        break;
                    }
                case Constants.Route:
                    {
                        pnlRoute.Location = new Point(0, 0);
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
                        break;
                    }
                default:
                    break;
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Stellt ein Dictionary anhand der ausgefüllten Filterfelder zusammen und gibt es zurück
        /// </summary>
        /// <returns>Dictionary mit den gefüllten Feldern und ihren Werten</returns>
        public Dictionary<string, string> GetFilterDict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            //Route Panel
            if (!String.IsNullOrEmpty(txtRouteName.Text))
                dict.Add(Fld.Name, txtRouteName.Text);
            if (!String.IsNullOrEmpty(cbxRouteRiver.Text))
                dict.Add(Fld.Name, cbxRouteRiver.Text);
            if (!String.IsNullOrEmpty(cbxRouteStart.Text))
                dict.Add(Fld.Name, cbxRouteStart.Text);
            if (!String.IsNullOrEmpty(cbxRouteEnd.Text))
                dict.Add(Fld.Name, cbxRouteEnd.Text);
            if (!String.IsNullOrEmpty(txtRouteWWLevel.Text))
                dict.Add(Fld.Name, txtRouteWWLevel.Text);
            //River Panel
            if (!String.IsNullOrEmpty(txtRiverName.Text))
                dict.Add(Fld.Name, txtRiverName.Text);
            if (!string.IsNullOrEmpty(txtRiverLand.Text))
                dict.Add(Fld.Land, txtRiverLand.Text);
            dict.Add(Fld.Ticket, chkRiverTicket.Checked.ToString());
            if (string.IsNullOrEmpty(txtRiverTicketPrice.Text))
                dict.Add(Fld.Ticketpreis, txtRiverTicketPrice.Text);
            if (string.IsNullOrEmpty(txtRiverWWLevel.Text))
                dict.Add(Fld.WWLevel, txtRiverWWLevel.Text);
            //Sart End Panel
            if (!String.IsNullOrEmpty(txtStartEndName.Text))
                dict.Add(Fld.Name, txtStartEndName.Text);
            if (!String.IsNullOrEmpty(txtStartEndLand.Text))
                dict.Add(Fld.Name, txtStartEndLand.Text);
            dict.Add(Fld.Name, chkStartEndEnd.Checked.ToString());
            dict.Add(Fld.Name, chkStartEndStart.Checked.ToString());
            if (!String.IsNullOrEmpty(mtxtStartEndCoordinates.Text))
                dict.Add(Fld.Name, mtxtStartEndCoordinates.Text);

            return dict;
        }

        #endregion Methoden

    }
}
