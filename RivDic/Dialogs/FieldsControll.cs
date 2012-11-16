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
            this.Size = new Size(220, 150);            
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
                        pnlRiverSearch.Location = new Point(0, 0);
                        break;
                    }
                case Constants.Route:
                    {
                        pnlRouteSearch.Location = new Point(0, 0);
                        break;
                    }
                case Constants.StartEnd:
                    {
                        pnlStartEndSearch.Location = new Point(0, 0);
                        break;
                    }
                default:
                    break;
            }
        }

        #endregion Methoden
    }
}
