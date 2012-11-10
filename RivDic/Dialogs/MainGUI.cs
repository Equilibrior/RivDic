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
        public MainGUI()
        {
            InitializeComponent();
        }

        private void btnRiver_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.RIVER))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                { 
                    
                }


            }
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.ROUTE))
            {
                dlg.ShowDialog();
            }
        }

        private void btnStartEnd_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.STARTEND))
            {
                dlg.ShowDialog();
            }
        }

        private void btnSearchRiver_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
