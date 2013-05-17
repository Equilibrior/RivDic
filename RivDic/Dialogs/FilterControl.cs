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

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Verbindet die Events
        /// </summary>
        private void ConnectEvents()
        {
            btnFilterRiver.Click += btnFilterRiver_Click;
            btnFilterRoute.Click += btnFilterRoute_Click;
            btnFilterStartEnd.Click += btnFilterStartEnd_Click;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterRiver_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterStartEnd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterRoute_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion Methoden

    }
}
