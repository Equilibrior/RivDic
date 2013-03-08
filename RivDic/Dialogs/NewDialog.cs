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
        /// Erweiterter Konstruktor
        /// </summary>
        public NewDialog(string mode)
        {   
            InitializeComponent();
            this.context = mode;
            fieldsControll.ShowPanel(mode);
        }

        #endregion Konstruktor

        #region Properties

        private string context;

        /// <summary>Bestimmt anhand des Contextes die Tabelle</summary>
        private string tableName 
        { 
            get
            {
                if (context.Equals(Constants.River))
                    return Tbl.Fluesse;
                else if(context.Equals(Constants.Route))
                    return Tbl.FlussAbschnitt;
                else 
                    return Tbl.StartEnde;
            }
        }

        #endregion Properties

        #region Methoden

        private void btnOk_Click(object sender, EventArgs e)
        {
            Database.SaveData(tableName, fieldsControll.GetSaveDict(context));
        }

        #endregion Methoden



    }
}
