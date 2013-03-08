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
            this.fieldsControll = new RivDic.Dialogs.FieldsControll();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateRoute = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.menuStrip.SuspendLayout();
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
            // fieldsControll
            // 
            this.fieldsControll.BackColor = System.Drawing.Color.Transparent;
            this.fieldsControll.Location = new System.Drawing.Point(12, 27);
            this.fieldsControll.Name = "fieldsControll";
            this.fieldsControll.Size = new System.Drawing.Size(220, 200);
            this.fieldsControll.TabIndex = 1;
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
            this.menuStrip.Size = new System.Drawing.Size(372, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(71, 20);
            this.mnuSave.Text = "Speichern";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
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
            // mnuCalculateRoute
            // 
            this.mnuCalculateRoute.Name = "mnuCalculateRoute";
            this.mnuCalculateRoute.Size = new System.Drawing.Size(89, 20);
            this.mnuCalculateRoute.Text = "Route planen";
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
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
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
    }
}