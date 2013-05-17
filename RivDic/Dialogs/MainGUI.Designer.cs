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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuNewRiver = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuNewRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuNewStartEnd = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuNew});
            this.mnuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(166, 24);
            this.mnuBar.TabIndex = 2;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuNew
            // 
            this.mnuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuNewRiver,
            this.smnuNewRoute,
            this.smnuNewStartEnd});
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(41, 20);
            this.mnuNew.Text = "Neu";
            // 
            // smnuNewRiver
            // 
            this.smnuNewRiver.Name = "smnuNewRiver";
            this.smnuNewRiver.Size = new System.Drawing.Size(206, 22);
            this.smnuNewRiver.Text = "Neuer Fluss";
            this.smnuNewRiver.Click += new System.EventHandler(this.btnRiverNew_Click);
            // 
            // smnuNewRoute
            // 
            this.smnuNewRoute.Name = "smnuNewRoute";
            this.smnuNewRoute.Size = new System.Drawing.Size(206, 22);
            this.smnuNewRoute.Text = "Neue Strecke";
            this.smnuNewRoute.Click += new System.EventHandler(this.btnRouteNew_Click);
            // 
            // smnuNewStartEnd
            // 
            this.smnuNewStartEnd.Name = "smnuNewStartEnd";
            this.smnuNewStartEnd.Size = new System.Drawing.Size(206, 22);
            this.smnuNewStartEnd.Text = "Neuer Ein-/Aussetzpunkt";
            this.smnuNewStartEnd.Click += new System.EventHandler(this.btnStartEndNew_Click);
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
            this.ClientSize = new System.Drawing.Size(166, 172);
            this.Controls.Add(this.btnSearchStartEnd);
            this.Controls.Add(this.btnSearchRoute);
            this.Controls.Add(this.btnSearchRiver);
            this.Controls.Add(this.mnuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Button btnSearchRiver;
        private System.Windows.Forms.Button btnSearchRoute;
        private System.Windows.Forms.Button btnSearchStartEnd;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem smnuNewRiver;
        private System.Windows.Forms.ToolStripMenuItem smnuNewRoute;
        private System.Windows.Forms.ToolStripMenuItem smnuNewStartEnd;
    }
}

