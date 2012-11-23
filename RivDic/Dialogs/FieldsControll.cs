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
            this.Size = new Size(220, 400);            
        }

        #endregion Konstruktor

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Rückt das aktuelle Panel an erste Stelle
        /// </summary>
        /// <param name="context">Kontext des Panels</param>
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

        public void SetPanelReadOnly(string panel, bool value)
        {
            switch (panel)
            {
                case Constants.River:
                default:
                    {
                        txtRiverLand.ReadOnly = value;
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

        public void SetContent(string panel, DataGridViewRow row)
        {
            switch (panel)
            {
                case Constants.River:
                default:
                    {
                        txtRiverLand.Text = row.Cells[Fld.Land].Value.ToString();
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

        #endregion Methoden
    }
}
