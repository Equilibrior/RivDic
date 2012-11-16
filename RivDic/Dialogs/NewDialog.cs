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
        }

        #endregion Konstruktor

        #region Properties

        

        #endregion Properties

        #region Methoden

        private void btnOk_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion Methoden              

       

    }
}
