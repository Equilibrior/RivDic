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
    public partial class DetailDialog : Form
    {
        #region Konstruktor

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context">Kontext des Dialoges</param>
        public DetailDialog(string context)
        {
            InitializeComponent();
            this.context = context;
            LoadData(context);
            fieldsControll.ShowPanel(context);
            fieldsControll.SetPanelReadOnly(context, true);            
            gridView.ReadOnly = true;
            EnableCommands();
        }

        #endregion Konstruktor

        #region Properties

        private string context;

        private Boolean editMode = false;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bestimmt anhand des Kontextes den Tabellennamen 
        /// </summary>
        public string tableName
        {
            get
            {
                if (context.Equals(Constants.River))
                    return Tbl.Fluesse;
                else if (context.Equals(Constants.Route))
                    return Tbl.FlussAbschnitt;
                else
                    return Tbl.StartEnde;
            }
        }

        #endregion Properties

        #region Methoden

        private void EnableCommands()
        {
            mnuEdit.Visible = !editMode;
            mnuSave.Visible = editMode;
            if (context.Equals(Constants.StartEnd))
                mnuCalculateRoute.Visible = true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lädt die Daten
        /// </summary>
        /// <param name="context">Kontext der Daten zum Laden</param>
        private void LoadData(string context)
        {
            switch (context)
            {
                case Constants.River:
                    {
                        gridView.DataSource = Database.LoadDataTable(Tbl.Fluesse);
                        break;
                    }
                case Constants.Route:
                    {
                        gridView.DataSource = Database.LoadDataTable(Tbl.FlussAbschnitt);
                        break;
                    }
                case Constants.StartEnd:
                    {
                        gridView.DataSource = Database.LoadDataTable(Tbl.StartEnde);
                        break;
                    }
                default:
                    break;
            }
        }


        private void mnuEdit_Click(object sender, EventArgs e)
        {
            editMode = true;
            fieldsControll.SetPanelReadOnly(context, false);
            EnableCommands();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (Database.SaveData(tableName, fieldsControll.GetSaveDict(context)))
            {
                editMode = false;
                EnableCommands();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Es konnten keine Daten gespeichert werden.");
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                string id = gridView.SelectedRows[0].Cells[Fld.Id].Value.ToString();
                StringBuilder sb = new StringBuilder("DELETE FROM ");

                if (context.Equals(Constants.River))
                    sb.Append(Tbl.Fluesse);
                else if (context.Equals(Constants.Route))
                    sb.Append(Tbl.FlussAbschnitt);
                else if (context.Equals(Constants.StartEnd))
                    sb.Append(Tbl.StartEnde);

                sb.Append(" WHERE ID = '" + id + "'");
                Database.ExecuteQuery(sb.ToString());
                gridView.Rows.Remove(gridView.SelectedRows[0]);
            }
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            fieldsControll.SetContent(context, row);
        }

        private void mnuCalculateRoute_Click(object sender, EventArgs e)
        {
            string coordinates = fieldsControll.GetCoordinatesText();
            System.Diagnostics.Process.Start("https://maps.google.de/maps?q=" + coordinates);
        }

        #endregion Methoden






    }
}
