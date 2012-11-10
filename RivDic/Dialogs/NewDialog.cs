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
            ChangePanel(mode);
        }

        #endregion Konstruktor

        #region Properties

        

        #endregion Properties

        #region Methoden

        private void ChangePanel(string mode)
        {
            switch (mode)
            {                
                case Constants.Route:
                    pnlRiverNew.Visible = false;
                    pnlRouteNew.Visible = true;
                    pnlStartEndNew.Visible = false;
                    break;
                case Constants.StartEnd:
                    pnlRiverNew.Visible = false;
                    pnlRouteNew.Visible = false;
                    pnlStartEndNew.Visible = true;
                    break;                
                case Constants.River:
                default:
                    pnlRiverNew.Visible = true;
                    pnlRouteNew.Visible = false;
                    pnlStartEndNew.Visible = false;
                    break;
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion Methoden              

       

    }
}
