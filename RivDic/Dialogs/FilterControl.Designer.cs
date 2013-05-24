namespace RivDic.Dialogs
{
    partial class FilterControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlRoute = new System.Windows.Forms.Panel();
            this.btnFilterRoute = new System.Windows.Forms.Button();
            this.cbxRouteStart = new System.Windows.Forms.ComboBox();
            this.cbxRouteEnd = new System.Windows.Forms.ComboBox();
            this.cbxRouteRiver = new System.Windows.Forms.ComboBox();
            this.lblRouteRiver = new System.Windows.Forms.Label();
            this.lblRouteStart = new System.Windows.Forms.Label();
            this.txtRouteWWLevel = new System.Windows.Forms.TextBox();
            this.lblRouteWWLevel = new System.Windows.Forms.Label();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.lblRouteEnd = new System.Windows.Forms.Label();
            this.pnlRiver = new System.Windows.Forms.Panel();
            this.btnFilterRiver = new System.Windows.Forms.Button();
            this.lblRiverTicketPricer = new System.Windows.Forms.Label();
            this.chkRiverTicket = new System.Windows.Forms.CheckBox();
            this.txtRiverTicketPrice = new System.Windows.Forms.TextBox();
            this.lblRiverTicket = new System.Windows.Forms.Label();
            this.txtRiverWWLevel = new System.Windows.Forms.TextBox();
            this.lblRiverWWLevel = new System.Windows.Forms.Label();
            this.txtRiverLand = new System.Windows.Forms.TextBox();
            this.lblRiverLand = new System.Windows.Forms.Label();
            this.txtRiverName = new System.Windows.Forms.TextBox();
            this.lblRiverName = new System.Windows.Forms.Label();
            this.pnlStartEnd = new System.Windows.Forms.Panel();
            this.btnFilterStartEnd = new System.Windows.Forms.Button();
            this.mtxtStartEndCoordinates = new System.Windows.Forms.MaskedTextBox();
            this.lblStartEndCoordinates = new System.Windows.Forms.Label();
            this.chkStartEndStart = new System.Windows.Forms.CheckBox();
            this.chkStartEndEnd = new System.Windows.Forms.CheckBox();
            this.txtStartEndLand = new System.Windows.Forms.TextBox();
            this.lblStartEndLand = new System.Windows.Forms.Label();
            this.txtStartEndName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartEndeEnd = new System.Windows.Forms.Label();
            this.lblStartEndeStart = new System.Windows.Forms.Label();
            this.pnlRoute.SuspendLayout();
            this.pnlRiver.SuspendLayout();
            this.pnlStartEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoute
            // 
            this.pnlRoute.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoute.Controls.Add(this.btnFilterRoute);
            this.pnlRoute.Controls.Add(this.cbxRouteStart);
            this.pnlRoute.Controls.Add(this.cbxRouteEnd);
            this.pnlRoute.Controls.Add(this.cbxRouteRiver);
            this.pnlRoute.Controls.Add(this.lblRouteRiver);
            this.pnlRoute.Controls.Add(this.lblRouteStart);
            this.pnlRoute.Controls.Add(this.txtRouteWWLevel);
            this.pnlRoute.Controls.Add(this.lblRouteWWLevel);
            this.pnlRoute.Controls.Add(this.lblRouteName);
            this.pnlRoute.Controls.Add(this.txtRouteName);
            this.pnlRoute.Controls.Add(this.lblRouteEnd);
            this.pnlRoute.Location = new System.Drawing.Point(5, 160);
            this.pnlRoute.Margin = new System.Windows.Forms.Padding(5);
            this.pnlRoute.Name = "pnlRoute";
            this.pnlRoute.Size = new System.Drawing.Size(565, 63);
            this.pnlRoute.TabIndex = 7;
            // 
            // btnFilterRoute
            // 
            this.btnFilterRoute.Location = new System.Drawing.Point(487, 37);
            this.btnFilterRoute.Name = "btnFilterRoute";
            this.btnFilterRoute.Size = new System.Drawing.Size(75, 23);
            this.btnFilterRoute.TabIndex = 15;
            this.btnFilterRoute.Text = "Filter";
            this.btnFilterRoute.UseVisualStyleBackColor = true;
            // 
            // cbxRouteStart
            // 
            this.cbxRouteStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRouteStart.FormattingEnabled = true;
            this.cbxRouteStart.Location = new System.Drawing.Point(227, 3);
            this.cbxRouteStart.Name = "cbxRouteStart";
            this.cbxRouteStart.Size = new System.Drawing.Size(116, 21);
            this.cbxRouteStart.TabIndex = 14;
            // 
            // cbxRouteEnd
            // 
            this.cbxRouteEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRouteEnd.FormattingEnabled = true;
            this.cbxRouteEnd.Location = new System.Drawing.Point(227, 30);
            this.cbxRouteEnd.Name = "cbxRouteEnd";
            this.cbxRouteEnd.Size = new System.Drawing.Size(116, 21);
            this.cbxRouteEnd.TabIndex = 13;
            // 
            // cbxRouteRiver
            // 
            this.cbxRouteRiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRouteRiver.FormattingEnabled = true;
            this.cbxRouteRiver.Location = new System.Drawing.Point(55, 26);
            this.cbxRouteRiver.Name = "cbxRouteRiver";
            this.cbxRouteRiver.Size = new System.Drawing.Size(116, 21);
            this.cbxRouteRiver.TabIndex = 12;
            // 
            // lblRouteRiver
            // 
            this.lblRouteRiver.AutoSize = true;
            this.lblRouteRiver.Location = new System.Drawing.Point(6, 29);
            this.lblRouteRiver.Name = "lblRouteRiver";
            this.lblRouteRiver.Size = new System.Drawing.Size(31, 13);
            this.lblRouteRiver.TabIndex = 8;
            this.lblRouteRiver.Text = "Fluss";
            // 
            // lblRouteStart
            // 
            this.lblRouteStart.AutoSize = true;
            this.lblRouteStart.Location = new System.Drawing.Point(177, 6);
            this.lblRouteStart.Name = "lblRouteStart";
            this.lblRouteStart.Size = new System.Drawing.Size(44, 13);
            this.lblRouteStart.TabIndex = 4;
            this.lblRouteStart.Text = "Einstieg";
            // 
            // txtRouteWWLevel
            // 
            this.txtRouteWWLevel.Location = new System.Drawing.Point(446, 3);
            this.txtRouteWWLevel.Name = "txtRouteWWLevel";
            this.txtRouteWWLevel.Size = new System.Drawing.Size(116, 20);
            this.txtRouteWWLevel.TabIndex = 4;
            // 
            // lblRouteWWLevel
            // 
            this.lblRouteWWLevel.AutoSize = true;
            this.lblRouteWWLevel.Location = new System.Drawing.Point(349, 6);
            this.lblRouteWWLevel.Name = "lblRouteWWLevel";
            this.lblRouteWWLevel.Size = new System.Drawing.Size(84, 13);
            this.lblRouteWWLevel.TabIndex = 4;
            this.lblRouteWWLevel.Text = "Wildwasserstufe";
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Location = new System.Drawing.Point(6, 6);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(35, 13);
            this.lblRouteName.TabIndex = 0;
            this.lblRouteName.Text = "Name";
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(55, 0);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(116, 20);
            this.txtRouteName.TabIndex = 1;
            // 
            // lblRouteEnd
            // 
            this.lblRouteEnd.AutoSize = true;
            this.lblRouteEnd.Location = new System.Drawing.Point(177, 29);
            this.lblRouteEnd.Name = "lblRouteEnd";
            this.lblRouteEnd.Size = new System.Drawing.Size(47, 13);
            this.lblRouteEnd.TabIndex = 6;
            this.lblRouteEnd.Text = "Ausstieg";
            // 
            // pnlRiver
            // 
            this.pnlRiver.BackColor = System.Drawing.Color.Transparent;
            this.pnlRiver.Controls.Add(this.btnFilterRiver);
            this.pnlRiver.Controls.Add(this.lblRiverTicketPricer);
            this.pnlRiver.Controls.Add(this.chkRiverTicket);
            this.pnlRiver.Controls.Add(this.txtRiverTicketPrice);
            this.pnlRiver.Controls.Add(this.lblRiverTicket);
            this.pnlRiver.Controls.Add(this.txtRiverWWLevel);
            this.pnlRiver.Controls.Add(this.lblRiverWWLevel);
            this.pnlRiver.Controls.Add(this.txtRiverLand);
            this.pnlRiver.Controls.Add(this.lblRiverLand);
            this.pnlRiver.Controls.Add(this.txtRiverName);
            this.pnlRiver.Controls.Add(this.lblRiverName);
            this.pnlRiver.Location = new System.Drawing.Point(5, 233);
            this.pnlRiver.Margin = new System.Windows.Forms.Padding(5);
            this.pnlRiver.Name = "pnlRiver";
            this.pnlRiver.Size = new System.Drawing.Size(565, 56);
            this.pnlRiver.TabIndex = 8;
            // 
            // btnFilterRiver
            // 
            this.btnFilterRiver.Location = new System.Drawing.Point(487, 30);
            this.btnFilterRiver.Name = "btnFilterRiver";
            this.btnFilterRiver.Size = new System.Drawing.Size(75, 23);
            this.btnFilterRiver.TabIndex = 16;
            this.btnFilterRiver.Text = "Filter";
            this.btnFilterRiver.UseVisualStyleBackColor = true;
            // 
            // lblRiverTicketPricer
            // 
            this.lblRiverTicketPricer.AutoSize = true;
            this.lblRiverTicketPricer.Location = new System.Drawing.Point(166, 32);
            this.lblRiverTicketPricer.Name = "lblRiverTicketPricer";
            this.lblRiverTicketPricer.Size = new System.Drawing.Size(59, 13);
            this.lblRiverTicketPricer.TabIndex = 9;
            this.lblRiverTicketPricer.Text = "Ticketpreis";
            // 
            // chkRiverTicket
            // 
            this.chkRiverTicket.AutoSize = true;
            this.chkRiverTicket.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.chkRiverTicket.Location = new System.Drawing.Point(275, 6);
            this.chkRiverTicket.Name = "chkRiverTicket";
            this.chkRiverTicket.Size = new System.Drawing.Size(15, 14);
            this.chkRiverTicket.TabIndex = 4;
            this.chkRiverTicket.UseVisualStyleBackColor = true;
            // 
            // txtRiverTicketPrice
            // 
            this.txtRiverTicketPrice.Location = new System.Drawing.Point(231, 26);
            this.txtRiverTicketPrice.Name = "txtRiverTicketPrice";
            this.txtRiverTicketPrice.Size = new System.Drawing.Size(116, 20);
            this.txtRiverTicketPrice.TabIndex = 5;
            // 
            // lblRiverTicket
            // 
            this.lblRiverTicket.AutoSize = true;
            this.lblRiverTicket.Location = new System.Drawing.Point(166, 6);
            this.lblRiverTicket.Name = "lblRiverTicket";
            this.lblRiverTicket.Size = new System.Drawing.Size(37, 13);
            this.lblRiverTicket.TabIndex = 6;
            this.lblRiverTicket.Text = "Ticket";
            // 
            // txtRiverWWLevel
            // 
            this.txtRiverWWLevel.Location = new System.Drawing.Point(443, 3);
            this.txtRiverWWLevel.MaxLength = 5;
            this.txtRiverWWLevel.Name = "txtRiverWWLevel";
            this.txtRiverWWLevel.Size = new System.Drawing.Size(116, 20);
            this.txtRiverWWLevel.TabIndex = 3;
            // 
            // lblRiverWWLevel
            // 
            this.lblRiverWWLevel.AutoSize = true;
            this.lblRiverWWLevel.Location = new System.Drawing.Point(349, 6);
            this.lblRiverWWLevel.Name = "lblRiverWWLevel";
            this.lblRiverWWLevel.Size = new System.Drawing.Size(84, 13);
            this.lblRiverWWLevel.TabIndex = 4;
            this.lblRiverWWLevel.Text = "Wildwasserstufe";
            // 
            // txtRiverLand
            // 
            this.txtRiverLand.Location = new System.Drawing.Point(48, 29);
            this.txtRiverLand.MaxLength = 255;
            this.txtRiverLand.Name = "txtRiverLand";
            this.txtRiverLand.Size = new System.Drawing.Size(116, 20);
            this.txtRiverLand.TabIndex = 2;
            // 
            // lblRiverLand
            // 
            this.lblRiverLand.AutoSize = true;
            this.lblRiverLand.Location = new System.Drawing.Point(3, 32);
            this.lblRiverLand.Name = "lblRiverLand";
            this.lblRiverLand.Size = new System.Drawing.Size(31, 13);
            this.lblRiverLand.TabIndex = 2;
            this.lblRiverLand.Text = "Land";
            // 
            // txtRiverName
            // 
            this.txtRiverName.Location = new System.Drawing.Point(48, 3);
            this.txtRiverName.MaxLength = 255;
            this.txtRiverName.Name = "txtRiverName";
            this.txtRiverName.Size = new System.Drawing.Size(116, 20);
            this.txtRiverName.TabIndex = 1;
            // 
            // lblRiverName
            // 
            this.lblRiverName.AutoSize = true;
            this.lblRiverName.Location = new System.Drawing.Point(3, 6);
            this.lblRiverName.Name = "lblRiverName";
            this.lblRiverName.Size = new System.Drawing.Size(35, 13);
            this.lblRiverName.TabIndex = 0;
            this.lblRiverName.Text = "Name";
            // 
            // pnlStartEnd
            // 
            this.pnlStartEnd.BackColor = System.Drawing.Color.Transparent;
            this.pnlStartEnd.Controls.Add(this.btnFilterStartEnd);
            this.pnlStartEnd.Controls.Add(this.mtxtStartEndCoordinates);
            this.pnlStartEnd.Controls.Add(this.lblStartEndCoordinates);
            this.pnlStartEnd.Controls.Add(this.chkStartEndStart);
            this.pnlStartEnd.Controls.Add(this.chkStartEndEnd);
            this.pnlStartEnd.Controls.Add(this.txtStartEndLand);
            this.pnlStartEnd.Controls.Add(this.lblStartEndLand);
            this.pnlStartEnd.Controls.Add(this.txtStartEndName);
            this.pnlStartEnd.Controls.Add(this.lblName);
            this.pnlStartEnd.Controls.Add(this.lblStartEndeEnd);
            this.pnlStartEnd.Controls.Add(this.lblStartEndeStart);
            this.pnlStartEnd.Location = new System.Drawing.Point(5, 294);
            this.pnlStartEnd.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStartEnd.Name = "pnlStartEnd";
            this.pnlStartEnd.Size = new System.Drawing.Size(565, 58);
            this.pnlStartEnd.TabIndex = 9;
            // 
            // btnFilterStartEnd
            // 
            this.btnFilterStartEnd.Location = new System.Drawing.Point(487, 32);
            this.btnFilterStartEnd.Name = "btnFilterStartEnd";
            this.btnFilterStartEnd.Size = new System.Drawing.Size(75, 23);
            this.btnFilterStartEnd.TabIndex = 17;
            this.btnFilterStartEnd.Text = "Filter";
            this.btnFilterStartEnd.UseVisualStyleBackColor = true;
            // 
            // mtxtStartEndCoordinates
            // 
            this.mtxtStartEndCoordinates.Location = new System.Drawing.Point(331, 3);
            this.mtxtStartEndCoordinates.Mask = "00,000000. 00,000000";
            this.mtxtStartEndCoordinates.Name = "mtxtStartEndCoordinates";
            this.mtxtStartEndCoordinates.Size = new System.Drawing.Size(116, 20);
            this.mtxtStartEndCoordinates.TabIndex = 8;
            // 
            // lblStartEndCoordinates
            // 
            this.lblStartEndCoordinates.AutoSize = true;
            this.lblStartEndCoordinates.Location = new System.Drawing.Point(261, 6);
            this.lblStartEndCoordinates.Name = "lblStartEndCoordinates";
            this.lblStartEndCoordinates.Size = new System.Drawing.Size(64, 13);
            this.lblStartEndCoordinates.TabIndex = 8;
            this.lblStartEndCoordinates.Text = "Koordinaten";
            // 
            // chkStartEndStart
            // 
            this.chkStartEndStart.AutoSize = true;
            this.chkStartEndStart.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.chkStartEndStart.Location = new System.Drawing.Point(240, 6);
            this.chkStartEndStart.Name = "chkStartEndStart";
            this.chkStartEndStart.Size = new System.Drawing.Size(15, 14);
            this.chkStartEndStart.TabIndex = 10;
            this.chkStartEndStart.UseVisualStyleBackColor = true;
            // 
            // chkStartEndEnd
            // 
            this.chkStartEndEnd.AutoSize = true;
            this.chkStartEndEnd.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.chkStartEndEnd.Location = new System.Drawing.Point(240, 32);
            this.chkStartEndEnd.Name = "chkStartEndEnd";
            this.chkStartEndEnd.Size = new System.Drawing.Size(15, 14);
            this.chkStartEndEnd.TabIndex = 11;
            this.chkStartEndEnd.UseVisualStyleBackColor = true;
            // 
            // txtStartEndLand
            // 
            this.txtStartEndLand.Location = new System.Drawing.Point(44, 29);
            this.txtStartEndLand.Name = "txtStartEndLand";
            this.txtStartEndLand.Size = new System.Drawing.Size(116, 20);
            this.txtStartEndLand.TabIndex = 9;
            // 
            // lblStartEndLand
            // 
            this.lblStartEndLand.AutoSize = true;
            this.lblStartEndLand.Location = new System.Drawing.Point(6, 32);
            this.lblStartEndLand.Name = "lblStartEndLand";
            this.lblStartEndLand.Size = new System.Drawing.Size(31, 13);
            this.lblStartEndLand.TabIndex = 10;
            this.lblStartEndLand.Text = "Land";
            // 
            // txtStartEndName
            // 
            this.txtStartEndName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartEndName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartEndName.Location = new System.Drawing.Point(44, 4);
            this.txtStartEndName.Name = "txtStartEndName";
            this.txtStartEndName.Size = new System.Drawing.Size(116, 20);
            this.txtStartEndName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblStartEndeEnd
            // 
            this.lblStartEndeEnd.AutoSize = true;
            this.lblStartEndeEnd.Location = new System.Drawing.Point(166, 32);
            this.lblStartEndeEnd.Name = "lblStartEndeEnd";
            this.lblStartEndeEnd.Size = new System.Drawing.Size(71, 13);
            this.lblStartEndeEnd.TabIndex = 2;
            this.lblStartEndeEnd.Text = "Aussetzpunkt";
            // 
            // lblStartEndeStart
            // 
            this.lblStartEndeStart.AutoSize = true;
            this.lblStartEndeStart.Location = new System.Drawing.Point(166, 6);
            this.lblStartEndeStart.Name = "lblStartEndeStart";
            this.lblStartEndeStart.Size = new System.Drawing.Size(68, 13);
            this.lblStartEndeStart.TabIndex = 0;
            this.lblStartEndeStart.Text = "Einsetzpunkt";
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlStartEnd);
            this.Controls.Add(this.pnlRiver);
            this.Controls.Add(this.pnlRoute);
            this.MinimumSize = new System.Drawing.Size(565, 2);
            this.Name = "FilterControl";
            this.Size = new System.Drawing.Size(576, 361);
            this.pnlRoute.ResumeLayout(false);
            this.pnlRoute.PerformLayout();
            this.pnlRiver.ResumeLayout(false);
            this.pnlRiver.PerformLayout();
            this.pnlStartEnd.ResumeLayout(false);
            this.pnlStartEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoute;
        private System.Windows.Forms.ComboBox cbxRouteStart;
        private System.Windows.Forms.ComboBox cbxRouteEnd;
        private System.Windows.Forms.ComboBox cbxRouteRiver;
        private System.Windows.Forms.Label lblRouteRiver;
        private System.Windows.Forms.Label lblRouteStart;
        private System.Windows.Forms.TextBox txtRouteWWLevel;
        private System.Windows.Forms.Label lblRouteWWLevel;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label lblRouteEnd;
        private System.Windows.Forms.Panel pnlRiver;
        private System.Windows.Forms.Label lblRiverTicketPricer;
        private System.Windows.Forms.CheckBox chkRiverTicket;
        private System.Windows.Forms.TextBox txtRiverTicketPrice;
        private System.Windows.Forms.Label lblRiverTicket;
        private System.Windows.Forms.TextBox txtRiverWWLevel;
        private System.Windows.Forms.Label lblRiverWWLevel;
        private System.Windows.Forms.TextBox txtRiverLand;
        private System.Windows.Forms.Label lblRiverLand;
        private System.Windows.Forms.TextBox txtRiverName;
        private System.Windows.Forms.Label lblRiverName;
        private System.Windows.Forms.Panel pnlStartEnd;
        private System.Windows.Forms.MaskedTextBox mtxtStartEndCoordinates;
        private System.Windows.Forms.Label lblStartEndCoordinates;
        private System.Windows.Forms.CheckBox chkStartEndStart;
        private System.Windows.Forms.CheckBox chkStartEndEnd;
        private System.Windows.Forms.TextBox txtStartEndLand;
        private System.Windows.Forms.Label lblStartEndLand;
        private System.Windows.Forms.TextBox txtStartEndName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartEndeEnd;
        private System.Windows.Forms.Label lblStartEndeStart;
        public System.Windows.Forms.Button btnFilterRoute;
        public System.Windows.Forms.Button btnFilterRiver;
        public System.Windows.Forms.Button btnFilterStartEnd;

    }
}
