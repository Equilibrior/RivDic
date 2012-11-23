namespace RivDic
{
    partial class MainGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.sbtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRiverNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRouteNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartEndNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchRiver = new System.Windows.Forms.Button();
            this.btnSearchRoute = new System.Windows.Forms.Button();
            this.btnSearchStartEnd = new System.Windows.Forms.Button();
            this.mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(163, 24);
            this.mnuBar.TabIndex = 2;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbtnNew,
            this.btnClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 20);
            this.mnuFile.Text = "Datei";
            // 
            // sbtnNew
            // 
            this.sbtnNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRiverNew,
            this.btnRouteNew,
            this.btnStartEndNew});
            this.sbtnNew.Name = "sbtnNew";
            this.sbtnNew.Size = new System.Drawing.Size(167, 22);
            this.sbtnNew.Text = "Neu";
            // 
            // btnRiverNew
            // 
            this.btnRiverNew.Name = "btnRiverNew";
            this.btnRiverNew.Size = new System.Drawing.Size(171, 22);
            this.btnRiverNew.Text = "Fluss";
            this.btnRiverNew.Click += new System.EventHandler(this.btnRiverNew_Click);
            // 
            // btnRouteNew
            // 
            this.btnRouteNew.Name = "btnRouteNew";
            this.btnRouteNew.Size = new System.Drawing.Size(171, 22);
            this.btnRouteNew.Text = "Strecke";
            this.btnRouteNew.Click += new System.EventHandler(this.btnRouteNew_Click);
            // 
            // btnStartEndNew
            // 
            this.btnStartEndNew.Name = "btnStartEndNew";
            this.btnStartEndNew.Size = new System.Drawing.Size(171, 22);
            this.btnStartEndNew.Text = "Ein-/Aussetzpunkt";
            this.btnStartEndNew.Click += new System.EventHandler(this.btnStartEndNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnClose.Size = new System.Drawing.Size(167, 22);
            this.btnClose.Text = "Schließen";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearchRiver
            // 
            this.btnSearchRiver.Location = new System.Drawing.Point(25, 27);
            this.btnSearchRiver.Name = "btnSearchRiver";
            this.btnSearchRiver.Size = new System.Drawing.Size(122, 35);
            this.btnSearchRiver.TabIndex = 3;
            this.btnSearchRiver.Text = "Fluss finden";
            this.btnSearchRiver.UseVisualStyleBackColor = true;
            this.btnSearchRiver.Click += new System.EventHandler(this.btnSearchRiver_Click);
            // 
            // btnSearchRoute
            // 
            this.btnSearchRoute.Location = new System.Drawing.Point(25, 68);
            this.btnSearchRoute.Name = "btnSearchRoute";
            this.btnSearchRoute.Size = new System.Drawing.Size(122, 35);
            this.btnSearchRoute.TabIndex = 4;
            this.btnSearchRoute.Text = "Strecke finden";
            this.btnSearchRoute.UseVisualStyleBackColor = true;
            this.btnSearchRoute.Click += new System.EventHandler(this.btnSearchRoute_Click);
            // 
            // btnSearchStartEnd
            // 
            this.btnSearchStartEnd.Location = new System.Drawing.Point(25, 109);
            this.btnSearchStartEnd.Name = "btnSearchStartEnd";
            this.btnSearchStartEnd.Size = new System.Drawing.Size(122, 35);
            this.btnSearchStartEnd.TabIndex = 5;
            this.btnSearchStartEnd.Text = "Ein-/Aussetzpunkt finden";
            this.btnSearchStartEnd.UseVisualStyleBackColor = true;
            this.btnSearchStartEnd.Click += new System.EventHandler(this.btnSearchStartEnd_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.ClientSize = new System.Drawing.Size(163, 171);
            this.Controls.Add(this.btnSearchStartEnd);
            this.Controls.Add(this.btnSearchRoute);
            this.Controls.Add(this.btnSearchRiver);
            this.Controls.Add(this.mnuBar);
            this.MainMenuStrip = this.mnuBar;
            this.Name = "MainGUI";
            this.Text = "RivDic";
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem sbtnNew;
        private System.Windows.Forms.ToolStripMenuItem btnRiverNew;
        private System.Windows.Forms.ToolStripMenuItem btnRouteNew;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnStartEndNew;
        private System.Windows.Forms.Button btnSearchRiver;
        private System.Windows.Forms.Button btnSearchRoute;
        private System.Windows.Forms.Button btnSearchStartEnd;
    }
}

