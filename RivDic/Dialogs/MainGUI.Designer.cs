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
            this.btnRiver = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchRiver = new System.Windows.Forms.Button();
            this.btnSearchRoute = new System.Windows.Forms.Button();
            this.btnSearchStartEnd = new System.Windows.Forms.Button();
            this.mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(201, 24);
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
            this.btnRiver,
            this.btnRoute,
            this.btnStartEnd});
            this.sbtnNew.Name = "sbtnNew";
            this.sbtnNew.Size = new System.Drawing.Size(167, 22);
            this.sbtnNew.Text = "Neu";
            // 
            // btnRiver
            // 
            this.btnRiver.Name = "btnRiver";
            this.btnRiver.Size = new System.Drawing.Size(171, 22);
            this.btnRiver.Text = "Fluss";
            this.btnRiver.Click += new System.EventHandler(this.btnRiver_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(171, 22);
            this.btnRoute.Text = "Strecke";
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnStartEnd
            // 
            this.btnStartEnd.Name = "btnStartEnd";
            this.btnStartEnd.Size = new System.Drawing.Size(171, 22);
            this.btnStartEnd.Text = "Ein-/Aussetzpunkt";
            this.btnStartEnd.Click += new System.EventHandler(this.btnStartEnd_Click);
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
            this.btnSearchRiver.Location = new System.Drawing.Point(41, 27);
            this.btnSearchRiver.Name = "btnSearchRiver";
            this.btnSearchRiver.Size = new System.Drawing.Size(122, 35);
            this.btnSearchRiver.TabIndex = 3;
            this.btnSearchRiver.Text = "Fluss finden";
            this.btnSearchRiver.UseVisualStyleBackColor = true;
            this.btnSearchRiver.Click += new System.EventHandler(this.btnSearchRiver_Click);
            // 
            // btnSearchRoute
            // 
            this.btnSearchRoute.Location = new System.Drawing.Point(41, 68);
            this.btnSearchRoute.Name = "btnSearchRoute";
            this.btnSearchRoute.Size = new System.Drawing.Size(122, 35);
            this.btnSearchRoute.TabIndex = 4;
            this.btnSearchRoute.Text = "Strecke finden";
            this.btnSearchRoute.UseVisualStyleBackColor = true;
            // 
            // btnSearchStartEnd
            // 
            this.btnSearchStartEnd.Location = new System.Drawing.Point(41, 109);
            this.btnSearchStartEnd.Name = "btnSearchStartEnd";
            this.btnSearchStartEnd.Size = new System.Drawing.Size(122, 35);
            this.btnSearchStartEnd.TabIndex = 5;
            this.btnSearchStartEnd.Text = "Ein-/Aussetzpunkt finden";
            this.btnSearchStartEnd.UseVisualStyleBackColor = true;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 246);
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
        private System.Windows.Forms.ToolStripMenuItem btnRiver;
        private System.Windows.Forms.ToolStripMenuItem btnRoute;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnStartEnd;
        private System.Windows.Forms.Button btnSearchRiver;
        private System.Windows.Forms.Button btnSearchRoute;
        private System.Windows.Forms.Button btnSearchStartEnd;
    }
}

