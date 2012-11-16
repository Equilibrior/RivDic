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
    public partial class FieldsControll : UserControl
    {
        public FieldsControll()
        {
            InitializeComponent();
            this.Size = new Size(220, 150);
        }

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
    }
}
