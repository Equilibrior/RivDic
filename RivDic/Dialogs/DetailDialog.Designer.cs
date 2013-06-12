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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailDialog));
            this.gridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.filterControl = new RivDic.Dialogs.FilterControl();
            this.fieldsControll = new RivDic.Dialogs.FieldsControll();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 310);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(570, 169);
            this.gridView.TabIndex = 0;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuEdit,
            this.mnuDelete,
            this.mnuCalculateRoute});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(594, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuSave
            // 
            this.mnuSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(71, 20);
            this.mnuSave.Text = "Speichern";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(75, 20);
            this.mnuEdit.Text = "Bearbeiten";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(63, 20);
            this.mnuDelete.Text = "Löschen";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuCalculateRoute
            // 
            this.mnuCalculateRoute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuCalculateRoute.Name = "mnuCalculateRoute";
            this.mnuCalculateRoute.Size = new System.Drawing.Size(89, 20);
            this.mnuCalculateRoute.Text = "Route planen";
            this.mnuCalculateRoute.Click += new System.EventHandler(this.mnuCalculateRoute_Click);
            // 
            // filterControl
            // 
            this.filterControl.BackColor = System.Drawing.Color.Transparent;
            this.filterControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterControl.Location = new System.Drawing.Point(12, 233);
            this.filterControl.MinimumSize = new System.Drawing.Size(565, 2);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(565, 71);
            this.filterControl.TabIndex = 3;
            // 
            // fieldsControll
            // 
            this.fieldsControll.BackColor = System.Drawing.Color.Transparent;
            this.fieldsControll.Location = new System.Drawing.Point(12, 27);
            this.fieldsControll.Name = "fieldsControll";
            this.fieldsControll.Size = new System.Drawing.Size(220, 200);
            this.fieldsControll.TabIndex = 1;
            // 
            // DetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.ClientSize = new System.Drawing.Size(594, 491);
            this.Controls.Add(this.filterControl);
            this.Controls.Add(this.fieldsControll);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 38);
            this.Name = "DetailDialog";
            this.ShowInTaskbar = false;
            this.Text = "DetailDialog";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private FieldsControll fieldsControll;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateRoute;
        private FilterControl filterControl;
    }
}