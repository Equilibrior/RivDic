using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RivDic.Dialogs;

namespace RivDic
{
    public partial class MainGUI : Form
    {
        #region Konstruktor

        public MainGUI()
        {
            InitializeComponent();
        }

        #endregion Konstruktor

        #region Methoden

        #region Neu anlegen

        private void btnRiverNew_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.River))
            {
                dlg.ShowDialog();
            }
        }

        private void btnRouteNew_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.Route))
            {
                dlg.ShowDialog();
            }
        }

        private void btnStartEndNew_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.StartEnd))
            {
                dlg.ShowDialog();
            }
        }
        #endregion Neu anlegen 

        #region Suchen

        private void btnSearchRiver_Click(object sender, EventArgs e)
        {
            SearchDialog dlg = new SearchDialog(Constants.River);
            dlg.ShowDialog();
        }        

        private void btnSearchStartEnd_Click(object sender, EventArgs e)
        {
            SearchDialog dlg = new SearchDialog(Constants.StartEnd);
            dlg.ShowDialog();
        }

        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            SearchDialog dlg = new SearchDialog(Constants.Route);
            dlg.ShowDialog();
        }

        #endregion Suchen

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Methoden
    }
}
