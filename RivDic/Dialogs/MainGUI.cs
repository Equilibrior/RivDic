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
    /// ============================================================================================================================
    public partial class MainGUI : Form
    {
        #region Konstruktor

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        public MainGUI()
        {
            InitializeComponent();
        }

        #endregion Konstruktor

        #region Methoden

        #region Neu anlegen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Öffnet den "Neu-anlegen"-Dialog mit Flüssen
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnRiverNew_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.River))
            {
                dlg.ShowDialog();
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Öffnet den "Neu-anlegen"-Dialog mit Routen
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnRouteNew_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.Route))
            {
                dlg.ShowDialog();
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Öffnet den "Neu-anlegen"-Dialog mit Start/End Punkten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartEndNew_Click(object sender, EventArgs e)
        {
            using (NewDialog dlg = new NewDialog(Constants.StartEnd))
            {
                dlg.ShowDialog();
            }
        }
        #endregion Neu anlegen 

        #region Suchen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Öffnet den "Suchen"-Dialog mit Flüssen
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSearchRiver_Click(object sender, EventArgs e)
        {
            DetailDialog dlg = new DetailDialog(Constants.River);
            dlg.ShowDialog();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Öffnet den "Suchen"-Dialog mit Start/End Punkten
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSearchStartEnd_Click(object sender, EventArgs e)
        {
            DetailDialog dlg = new DetailDialog(Constants.StartEnd);
            dlg.ShowDialog();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Öffnet den "Suchen"-Dialog mit Routen
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            DetailDialog dlg = new DetailDialog(Constants.Route);
            dlg.ShowDialog();
        }

        #endregion Suchen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Schließt den Dialog
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Methoden
    }
}
