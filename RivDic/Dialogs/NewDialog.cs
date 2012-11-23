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
    public partial class NewDialog : Form
    {
        #region Konstruktor

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Standard Konstruktor
        /// </summary>
        public NewDialog()
        {
            InitializeComponent();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Erweiterter Konstruktor
        /// </summary>
        public NewDialog(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            fieldsControll.ShowPanel(mode);
        }

        #endregion Konstruktor

        #region Properties

        private string mode;

        #endregion Properties

        #region Methoden

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Constants.River:
                    {
                        SaveRiver();
                        break;
                    }
                case Constants.Route:
                    {
                        SaveRoute();
                        break;
                    }
                case Constants.StartEnd:
                    {
                        SaveStartEnd();
                        break;
                    }
                default:
                    break;
            }
        }

        private Boolean SaveRiver()
        {
            Dictionary<string,object> dict= new Dictionary<string, object>();
            
            dict.Add(Fld.Id, Guid.NewGuid().ToString());
            dict.Add(Fld.Name, fieldsControll.txtRiverName.Text);
            dict.Add(Fld.Land, fieldsControll.txtRiverLand.Text);
            dict.Add(Fld.WWLevel, fieldsControll.txtRiverWWLevel.Text);
            dict.Add(Fld.Ticket, fieldsControll.chkRiverTicket.Checked.ToString());
            dict.Add(Fld.Ticketpreis, Convert.ToDouble(fieldsControll.txtRiverTicketPrice.Text));
            
            return Database.SaveData(Tbl.Fluesse, dict);
        }

        private Boolean SaveRoute()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add(Fld.Id, Guid.NewGuid().ToString());

            IdLabelItem idlItemRiver = fieldsControll.cbxRouteRiver.SelectedItem as IdLabelItem;
            dict.Add(Fld.FlussId, idlItemRiver.Id);

            dict.Add(Fld.WWLevel, fieldsControll.txtRouteWWLevel.Text);

            IdLabelItem idlItemStart = fieldsControll.cbxRouteStart.SelectedItem as IdLabelItem;
            dict.Add(Fld.Einsetzpunkt, idlItemStart);

            IdLabelItem idlItemEnd = fieldsControll.cbxRouteRiver.SelectedItem as IdLabelItem;
            dict.Add(Fld.Aussetzpunkt, idlItemEnd);

            dict.Add(Fld.Kommentar, fieldsControll.txtRouteComment.Text);
            dict.Add(Fld.Name, fieldsControll.txtRouteName.Text);

            return Database.SaveData(Tbl.FlussAbschnitt, dict);
        }

        private Boolean SaveStartEnd()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add(Fld.Id, Guid.NewGuid().ToString());
            dict.Add(Fld.Name, fieldsControll.txtStartEndName.Text);
            dict.Add(Fld.Land, fieldsControll.txtStartEndLand.Text);
            dict.Add(Fld.Koordinaten, fieldsControll.mtxtStartEndCoordinates.Text);
            dict.Add(Fld.Einsetzpunkt, fieldsControll.chkStartEndStart.Checked.ToString());
            dict.Add(Fld.Aussetzpunkt, fieldsControll.chkStartEndEnd.Checked.ToString());
            dict.Add(Fld.WWLevel, fieldsControll.txtRouteWWLevel.Text);

            return Database.SaveData(Tbl.StartEnde, dict);
        }

        #endregion Methoden



    }
}
