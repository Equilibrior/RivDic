namespace RivDic.Dialogs
{
    partial class DetailDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView = new System.Windows.Forms.DataGridView();
            this.mnuBrowseCoordinates = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldsControll = new RivDic.Dialogs.FieldsControll();
            this.mnuCalculateRoute = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.mnuBrowseCoordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 239);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(348, 169);
            this.gridView.TabIndex = 0;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // mnuBrowseCoordinates
            // 
            this.mnuBrowseCoordinates.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.mnuBrowseCoordinates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuDelete,
            this.mnuCalculateRoute});
            this.mnuBrowseCoordinates.Location = new System.Drawing.Point(0, 0);
            this.mnuBrowseCoordinates.Name = "mnuBrowseCoordinates";
            this.mnuBrowseCoordinates.Size = new System.Drawing.Size(372, 24);
            this.mnuBrowseCoordinates.TabIndex = 2;
            this.mnuBrowseCoordinates.Text = "Route planen";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(75, 20);
            this.mnuEdit.Text = "Bearbeiten";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(63, 20);
            this.mnuDelete.Text = "Löschen";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // fieldsControll
            // 
            this.fieldsControll.BackColor = System.Drawing.Color.Transparent;
            this.fieldsControll.Location = new System.Drawing.Point(12, 27);
            this.fieldsControll.Name = "fieldsControll";
            this.fieldsControll.Size = new System.Drawing.Size(220, 200);
            this.fieldsControll.TabIndex = 1;
            // 
            // mnuCalculateRoute
            // 
            this.mnuCalculateRoute.Name = "mnuCalculateRoute";
            this.mnuCalculateRoute.Size = new System.Drawing.Size(89, 20);
            this.mnuCalculateRoute.Text = "Route planen";
            this.mnuCalculateRoute.Visible = false;
            this.mnuCalculateRoute.Click += new System.EventHandler(this.mnuCalculateRoute_Click);
            // 
            // DetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.ClientSize = new System.Drawing.Size(372, 420);
            this.Controls.Add(this.fieldsControll);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.mnuBrowseCoordinates);
            this.MainMenuStrip = this.mnuBrowseCoordinates;
            this.Name = "DetailDialog";
            this.ShowInTaskbar = false;
            this.Text = "DetailDialog";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.mnuBrowseCoordinates.ResumeLayout(false);
            this.mnuBrowseCoordinates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private FieldsControll fieldsControll;
        private System.Windows.Forms.MenuStrip mnuBrowseCoordinates;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateRoute;
    }
}