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
    public partial class FieldsControll : UserControl
    {
        #region Konstruktor

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        public FieldsControll()
        {
            InitializeComponent();
            Size = new Size(220, 400);
        }

        #endregion Konstruktor

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Stellt ein Dictionary zum Speichern mit den entsprechenden Werten zusammen
        /// </summary>
        /// <param name="context">Der Kontext für den das Dictionary erstellt werden soll</param>
        /// <returns>Das Dictionary, das in die Datenbank geschrieben werden kann</returns>
        public Dictionary<string, object> GetSaveDict(string context)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            switch (context)
            {
                case Constants.River:
                    {
                        dict.Add(Fld.Id, Guid.NewGuid().ToString());
                        dict.Add(Fld.Name, txtRiverName.Text);
                        dict.Add(Fld.Land, cbxRiverLand.SelectedText);
                        dict.Add(Fld.WWLevel, txtRiverWWLevel.Text);
                        dict.Add(Fld.Ticket, chkRiverTicket.Checked.ToString());
                        if (!String.IsNullOrEmpty(txtRiverTicketPrice.Text))
                            dict.Add(Fld.Ticketpreis, Convert.ToDouble(txtRiverTicketPrice.Text));
                        else
                            dict.Add(Fld.Ticketpreis, 0.0);
                        break;
                    }
                case Constants.Route:
                    {
                        dict.Add(Fld.Id, Guid.NewGuid().ToString());
                        IdLabelItem idlItemRiver = cbxRouteRiver.SelectedItem as IdLabelItem;
                        dict.Add(Fld.FlussId, idlItemRiver.Id);
                        dict.Add(Fld.WWLevel, txtRouteWWLevel.Text);
                        IdLabelItem idlItemStart = cbxRouteStart.SelectedItem as IdLabelItem;
                        dict.Add(Fld.Einsetzpunkt, idlItemStart);
                        IdLabelItem idlItemEnd = cbxRouteRiver.SelectedItem as IdLabelItem;
                        dict.Add(Fld.Aussetzpunkt, idlItemEnd);
                        dict.Add(Fld.Kommentar, txtRouteComment.Text);
                        dict.Add(Fld.Name, txtRouteName.Text);
                        break;
                    }
                case Constants.StartEnd:
                    {
                        dict.Add(Fld.Id, Guid.NewGuid().ToString());
                        dict.Add(Fld.Name, txtStartEndName.Text);
                        dict.Add(Fld.Land, txtStartEndLand.Text);
                        dict.Add(Fld.Koordinaten, mtxtStartEndCoordinates.Text);
                        dict.Add(Fld.Einsetzpunkt, chkStartEndStart.Checked.ToString());
                        dict.Add(Fld.Aussetzpunkt, chkStartEndEnd.Checked.ToString());
                        dict.Add(Fld.WWLevel, txtRouteWWLevel.Text);
                        break;
                    }
                default:
                    break;
            }
            return dict;
        }

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
        /// Schaltet die ReadOnly Eigenschaft um.
        /// </summary>
        /// <param name="panel">Das Panel von dem die Eigenschaft umgeschaltet werden soll</param>
        /// <param name="value">True, wenn ReadOnly eingeschaltet werden soll</param>
        public void SetPanelReadOnly(string panel, bool value)
        {
            switch (panel)
            {
                case Constants.River:
                default:
                    {
                        cbxRiverLand.Enabled = value;
                        txtRiverName.ReadOnly = value;
                        txtRiverTicketPrice.ReadOnly = value;
                        txtRiverWWLevel.ReadOnly = value;
                        chkRiverTicket.Enabled = !value;
                        break;
                    }
                case Constants.Route:
                    {
                        txtRouteName.ReadOnly = value;
                        txtRouteComment.ReadOnly = value;
                        txtRouteWWLevel.ReadOnly = value;
                        cbxRouteRiver.Enabled = !value;
                        cbxRouteStart.Enabled = !value;
                        cbxRouteEnd.Enabled = !value;
                        break;
                    }
                case Constants.StartEnd:
                    {
                        txtStartEndName.ReadOnly = value;
                        txtStartEndLand.ReadOnly = value;
                        mtxtStartEndCoordinates.ReadOnly = value;
                        chkStartEndEnd.Enabled = !value;
                        chkStartEndStart.Enabled = !value;
                        break;
                    }
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Schreibt die Werte einer DataGridViewRow in die Felder des Panels
        /// </summary>
        /// <param name="panel">Von welchem Panel sollen die Felder gefüllt werden.</param>
        /// <param name="row">DataGridViewRow mit den Daten zum Füllen.</param>
        public void SetContent(string panel, DataGridViewRow row)
        {
            switch (panel)
            {
                case Constants.River:
                default:
                    {
                        cbxRiverLand.SelectedText = row.Cells[Fld.Land].Value.ToString();
                        txtRiverName.Text = row.Cells[Fld.Name].Value.ToString();
                        txtRiverTicketPrice.Text = row.Cells[Fld.Ticketpreis].Value.ToString();
                        txtRiverWWLevel.Text = row.Cells[Fld.WWLevel].Value.ToString();
                        chkRiverTicket.Checked = Convert.ToBoolean(row.Cells[Fld.Ticket].Value);
                        break;
                    }
                case Constants.Route:
                    {
                        txtRouteName.Text = row.Cells[Fld.Name].Value.ToString();
                        txtRouteComment.Text = row.Cells[Fld.Kommentar].Value.ToString();
                        txtRouteWWLevel.Text = row.Cells[Fld.WWLevel].Value.ToString();
                        cbxRouteRiver.SelectedValue = row.Cells[Fld.FlussId].Value;
                        cbxRouteStart.SelectedValue = row.Cells[Fld.Einsetzpunkt].Value;
                        cbxRouteEnd.SelectedValue = row.Cells[Fld.Aussetzpunkt].Value;
                        break;
                    }
                case Constants.StartEnd:
                    {
                        txtStartEndName.Text = row.Cells[Fld.Name].Value.ToString();
                        txtStartEndLand.Text = row.Cells[Fld.Land].Value.ToString();
                        mtxtStartEndCoordinates.Text = row.Cells[Fld.Koordinaten].Value.ToString();
                        chkStartEndEnd.Checked = Convert.ToBoolean(row.Cells["EINSTIEG"].Value);
                        chkStartEndStart.Checked = Convert.ToBoolean(row.Cells["AUSSTIEG"].Value);
                        break;
                    }
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liefert den Inhalt des Koordinaten Feldes
        /// </summary>
        /// <returns>Die Koordinaten</returns>
        public String GetCoordinatesText()
        {
            return mtxtStartEndCoordinates.Text;
        }

        #endregion Methoden

        private void cbbRiverLand_DropDown(object sender, EventArgs e)
        {
            if (cbxRiverLand.Items.Count < 1)
                cbxRiverLand.DataSource = Database.CountryList;
        }
    }
}
