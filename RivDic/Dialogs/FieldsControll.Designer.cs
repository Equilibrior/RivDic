namespace RivDic.Dialogs
{
    partial class FieldsControll
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
            this.pnlStartEnd = new System.Windows.Forms.Panel();
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
            this.txtRouteWWLevel = new System.Windows.Forms.TextBox();
            this.lblRouteWWLevel = new System.Windows.Forms.Label();
            this.pnlRoute = new System.Windows.Forms.Panel();
            this.cbxRouteStart = new System.Windows.Forms.ComboBox();
            this.cbxRouteEnd = new System.Windows.Forms.ComboBox();
            this.cbxRouteRiver = new System.Windows.Forms.ComboBox();
            this.lblRouteRiver = new System.Windows.Forms.Label();
            this.lblRouteStart = new System.Windows.Forms.Label();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.txtRouteComment = new System.Windows.Forms.TextBox();
            this.lblRouteEnd = new System.Windows.Forms.Label();
            this.lblRouteComment = new System.Windows.Forms.Label();
            this.pnlRiver = new System.Windows.Forms.Panel();
            this.lblRiverTicketPricer = new System.Windows.Forms.Label();
            this.chkRiverTicket = new System.Windows.Forms.CheckBox();
            this.txtRiverTicketPrice = new System.Windows.Forms.TextBox();
            this.lblRiverTicket = new System.Windows.Forms.Label();
            this.txtRiverWWLevel = new System.Windows.Forms.TextBox();
            this.lblRiverWWLevel = new System.Windows.Forms.Label();
            this.lblRiverLand = new System.Windows.Forms.Label();
            this.txtRiverName = new System.Windows.Forms.TextBox();
            this.lblRiverName = new System.Windows.Forms.Label();
            this.cbxRiverLand = new System.Windows.Forms.ComboBox();
            this.pnlStartEnd.SuspendLayout();
            this.pnlRoute.SuspendLayout();
            this.pnlRiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStartEnd
            // 
            this.pnlStartEnd.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlStartEnd.Location = new System.Drawing.Point(235, 355);
            this.pnlStartEnd.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStartEnd.Name = "pnlStartEnd";
            this.pnlStartEnd.Size = new System.Drawing.Size(218, 144);
            this.pnlStartEnd.TabIndex = 7;
            // 
            // mtxtStartEndCoordinates
            // 
            this.mtxtStartEndCoordinates.Location = new System.Drawing.Point(93, 59);
            this.mtxtStartEndCoordinates.Mask = "00,000000. 00,000000";
            this.mtxtStartEndCoordinates.Name = "mtxtStartEndCoordinates";
            this.mtxtStartEndCoordinates.Size = new System.Drawing.Size(116, 20);
            this.mtxtStartEndCoordinates.TabIndex = 8;
            // 
            // lblStartEndCoordinates
            // 
            this.lblStartEndCoordinates.AutoSize = true;
            this.lblStartEndCoordinates.Location = new System.Drawing.Point(6, 62);
            this.lblStartEndCoordinates.Name = "lblStartEndCoordinates";
            this.lblStartEndCoordinates.Size = new System.Drawing.Size(64, 13);
            this.lblStartEndCoordinates.TabIndex = 8;
            this.lblStartEndCoordinates.Text = "Koordinaten";
            // 
            // chkStartEndStart
            // 
            this.chkStartEndStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStartEndStart.AutoSize = true;
            this.chkStartEndStart.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.chkStartEndStart.Location = new System.Drawing.Point(142, 85);
            this.chkStartEndStart.Name = "chkStartEndStart";
            this.chkStartEndStart.Size = new System.Drawing.Size(15, 14);
            this.chkStartEndStart.TabIndex = 10;
            this.chkStartEndStart.UseVisualStyleBackColor = true;
            // 
            // chkStartEndEnd
            // 
            this.chkStartEndEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStartEndEnd.AutoSize = true;
            this.chkStartEndEnd.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.chkStartEndEnd.Location = new System.Drawing.Point(142, 108);
            this.chkStartEndEnd.Name = "chkStartEndEnd";
            this.chkStartEndEnd.Size = new System.Drawing.Size(15, 14);
            this.chkStartEndEnd.TabIndex = 11;
            this.chkStartEndEnd.UseVisualStyleBackColor = true;
            // 
            // txtStartEndLand
            // 
            this.txtStartEndLand.Location = new System.Drawing.Point(93, 33);
            this.txtStartEndLand.Name = "txtStartEndLand";
            this.txtStartEndLand.Size = new System.Drawing.Size(116, 20);
            this.txtStartEndLand.TabIndex = 9;
            // 
            // lblStartEndLand
            // 
            this.lblStartEndLand.AutoSize = true;
            this.lblStartEndLand.Location = new System.Drawing.Point(6, 36);
            this.lblStartEndLand.Name = "lblStartEndLand";
            this.lblStartEndLand.Size = new System.Drawing.Size(31, 13);
            this.lblStartEndLand.TabIndex = 10;
            this.lblStartEndLand.Text = "Land";
            // 
            // txtStartEndName
            // 
            this.txtStartEndName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartEndName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartEndName.Location = new System.Drawing.Point(93, 7);
            this.txtStartEndName.Name = "txtStartEndName";
            this.txtStartEndName.Size = new System.Drawing.Size(116, 20);
            this.txtStartEndName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(6, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblStartEndeEnd
            // 
            this.lblStartEndeEnd.AutoSize = true;
            this.lblStartEndeEnd.Location = new System.Drawing.Point(6, 108);
            this.lblStartEndeEnd.Name = "lblStartEndeEnd";
            this.lblStartEndeEnd.Size = new System.Drawing.Size(71, 13);
            this.lblStartEndeEnd.TabIndex = 2;
            this.lblStartEndeEnd.Text = "Aussetzpunkt";
            // 
            // lblStartEndeStart
            // 
            this.lblStartEndeStart.AutoSize = true;
            this.lblStartEndeStart.Location = new System.Drawing.Point(6, 85);
            this.lblStartEndeStart.Name = "lblStartEndeStart";
            this.lblStartEndeStart.Size = new System.Drawing.Size(68, 13);
            this.lblStartEndeStart.TabIndex = 0;
            this.lblStartEndeStart.Text = "Einsetzpunkt";
            // 
            // txtRouteWWLevel
            // 
            this.txtRouteWWLevel.Location = new System.Drawing.Point(93, 136);
            this.txtRouteWWLevel.Name = "txtRouteWWLevel";
            this.txtRouteWWLevel.Size = new System.Drawing.Size(116, 20);
            this.txtRouteWWLevel.TabIndex = 4;
            // 
            // lblRouteWWLevel
            // 
            this.lblRouteWWLevel.AutoSize = true;
            this.lblRouteWWLevel.Location = new System.Drawing.Point(6, 139);
            this.lblRouteWWLevel.Name = "lblRouteWWLevel";
            this.lblRouteWWLevel.Size = new System.Drawing.Size(84, 13);
            this.lblRouteWWLevel.TabIndex = 4;
            this.lblRouteWWLevel.Text = "Wildwasserstufe";
            // 
            // pnlRoute
            // 
            this.pnlRoute.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoute.Controls.Add(this.cbxRouteStart);
            this.pnlRoute.Controls.Add(this.cbxRouteEnd);
            this.pnlRoute.Controls.Add(this.cbxRouteRiver);
            this.pnlRoute.Controls.Add(this.lblRouteRiver);
            this.pnlRoute.Controls.Add(this.lblRouteStart);
            this.pnlRoute.Controls.Add(this.txtRouteWWLevel);
            this.pnlRoute.Controls.Add(this.lblRouteWWLevel);
            this.pnlRoute.Controls.Add(this.lblRouteName);
            this.pnlRoute.Controls.Add(this.txtRouteName);
            this.pnlRoute.Controls.Add(this.txtRouteComment);
            this.pnlRoute.Controls.Add(this.lblRouteEnd);
            this.pnlRoute.Controls.Add(this.lblRouteComment);
            this.pnlRoute.Location = new System.Drawing.Point(235, 29);
            this.pnlRoute.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoute.Name = "pnlRoute";
            this.pnlRoute.Size = new System.Drawing.Size(218, 170);
            this.pnlRoute.TabIndex = 6;
            // 
            // cbxRouteStart
            // 
            this.cbxRouteStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRouteStart.FormattingEnabled = true;
            this.cbxRouteStart.Location = new System.Drawing.Point(93, 56);
            this.cbxRouteStart.Name = "cbxRouteStart";
            this.cbxRouteStart.Size = new System.Drawing.Size(116, 21);
            this.cbxRouteStart.TabIndex = 14;
            // 
            // cbxRouteEnd
            // 
            this.cbxRouteEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRouteEnd.FormattingEnabled = true;
            this.cbxRouteEnd.Location = new System.Drawing.Point(93, 83);
            this.cbxRouteEnd.Name = "cbxRouteEnd";
            this.cbxRouteEnd.Size = new System.Drawing.Size(116, 21);
            this.cbxRouteEnd.TabIndex = 13;
            // 
            // cbxRouteRiver
            // 
            this.cbxRouteRiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRouteRiver.FormattingEnabled = true;
            this.cbxRouteRiver.Location = new System.Drawing.Point(93, 29);
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
            this.lblRouteStart.Location = new System.Drawing.Point(6, 59);
            this.lblRouteStart.Name = "lblRouteStart";
            this.lblRouteStart.Size = new System.Drawing.Size(44, 13);
            this.lblRouteStart.TabIndex = 4;
            this.lblRouteStart.Text = "Einstieg";
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
            this.txtRouteName.Location = new System.Drawing.Point(93, 3);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(116, 20);
            this.txtRouteName.TabIndex = 1;
            // 
            // txtRouteComment
            // 
            this.txtRouteComment.Location = new System.Drawing.Point(93, 110);
            this.txtRouteComment.Name = "txtRouteComment";
            this.txtRouteComment.Size = new System.Drawing.Size(116, 20);
            this.txtRouteComment.TabIndex = 5;
            // 
            // lblRouteEnd
            // 
            this.lblRouteEnd.AutoSize = true;
            this.lblRouteEnd.Location = new System.Drawing.Point(6, 86);
            this.lblRouteEnd.Name = "lblRouteEnd";
            this.lblRouteEnd.Size = new System.Drawing.Size(47, 13);
            this.lblRouteEnd.TabIndex = 6;
            this.lblRouteEnd.Text = "Ausstieg";
            // 
            // lblRouteComment
            // 
            this.lblRouteComment.AutoSize = true;
            this.lblRouteComment.Location = new System.Drawing.Point(6, 113);
            this.lblRouteComment.Name = "lblRouteComment";
            this.lblRouteComment.Size = new System.Drawing.Size(60, 13);
            this.lblRouteComment.TabIndex = 8;
            this.lblRouteComment.Text = "Kommentar";
            // 
            // pnlRiver
            // 
            this.pnlRiver.BackColor = System.Drawing.Color.Transparent;
            this.pnlRiver.Controls.Add(this.cbxRiverLand);
            this.pnlRiver.Controls.Add(this.lblRiverTicketPricer);
            this.pnlRiver.Controls.Add(this.chkRiverTicket);
            this.pnlRiver.Controls.Add(this.txtRiverTicketPrice);
            this.pnlRiver.Controls.Add(this.lblRiverTicket);
            this.pnlRiver.Controls.Add(this.txtRiverWWLevel);
            this.pnlRiver.Controls.Add(this.lblRiverWWLevel);
            this.pnlRiver.Controls.Add(this.lblRiverLand);
            this.pnlRiver.Controls.Add(this.txtRiverName);
            this.pnlRiver.Controls.Add(this.lblRiverName);
            this.pnlRiver.Location = new System.Drawing.Point(241, 209);
            this.pnlRiver.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRiver.Name = "pnlRiver";
            this.pnlRiver.Size = new System.Drawing.Size(212, 131);
            this.pnlRiver.TabIndex = 5;
            // 
            // lblRiverTicketPricer
            // 
            this.lblRiverTicketPricer.AutoSize = true;
            this.lblRiverTicketPricer.Location = new System.Drawing.Point(3, 105);
            this.lblRiverTicketPricer.Name = "lblRiverTicketPricer";
            this.lblRiverTicketPricer.Size = new System.Drawing.Size(59, 13);
            this.lblRiverTicketPricer.TabIndex = 9;
            this.lblRiverTicketPricer.Text = "Ticketpreis";
            // 
            // chkRiverTicket
            // 
            this.chkRiverTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRiverTicket.AutoSize = true;
            this.chkRiverTicket.BackgroundImage = global::RivDic.Properties.Resources.picBackgroundImage;
            this.chkRiverTicket.Location = new System.Drawing.Point(139, 82);
            this.chkRiverTicket.Name = "chkRiverTicket";
            this.chkRiverTicket.Size = new System.Drawing.Size(15, 14);
            this.chkRiverTicket.TabIndex = 4;
            this.chkRiverTicket.UseVisualStyleBackColor = true;
            // 
            // txtRiverTicketPrice
            // 
            this.txtRiverTicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRiverTicketPrice.Location = new System.Drawing.Point(93, 102);
            this.txtRiverTicketPrice.Name = "txtRiverTicketPrice";
            this.txtRiverTicketPrice.Size = new System.Drawing.Size(116, 20);
            this.txtRiverTicketPrice.TabIndex = 5;
            // 
            // lblRiverTicket
            // 
            this.lblRiverTicket.AutoSize = true;
            this.lblRiverTicket.Location = new System.Drawing.Point(5, 82);
            this.lblRiverTicket.Name = "lblRiverTicket";
            this.lblRiverTicket.Size = new System.Drawing.Size(37, 13);
            this.lblRiverTicket.TabIndex = 6;
            this.lblRiverTicket.Text = "Ticket";
            // 
            // txtRiverWWLevel
            // 
            this.txtRiverWWLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRiverWWLevel.Location = new System.Drawing.Point(93, 56);
            this.txtRiverWWLevel.MaxLength = 5;
            this.txtRiverWWLevel.Name = "txtRiverWWLevel";
            this.txtRiverWWLevel.Size = new System.Drawing.Size(116, 20);
            this.txtRiverWWLevel.TabIndex = 3;
            // 
            // lblRiverWWLevel
            // 
            this.lblRiverWWLevel.AutoSize = true;
            this.lblRiverWWLevel.Location = new System.Drawing.Point(3, 59);
            this.lblRiverWWLevel.Name = "lblRiverWWLevel";
            this.lblRiverWWLevel.Size = new System.Drawing.Size(84, 13);
            this.lblRiverWWLevel.TabIndex = 4;
            this.lblRiverWWLevel.Text = "Wildwasserstufe";
            // 
            // lblRiverLand
            // 
            this.lblRiverLand.AutoSize = true;
            this.lblRiverLand.Location = new System.Drawing.Point(3, 33);
            this.lblRiverLand.Name = "lblRiverLand";
            this.lblRiverLand.Size = new System.Drawing.Size(31, 13);
            this.lblRiverLand.TabIndex = 2;
            this.lblRiverLand.Text = "Land";
            // 
            // txtRiverName
            // 
            this.txtRiverName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRiverName.Location = new System.Drawing.Point(93, 4);
            this.txtRiverName.MaxLength = 255;
            this.txtRiverName.Name = "txtRiverName";
            this.txtRiverName.Size = new System.Drawing.Size(116, 20);
            this.txtRiverName.TabIndex = 1;
            // 
            // lblRiverName
            // 
            this.lblRiverName.AutoSize = true;
            this.lblRiverName.Location = new System.Drawing.Point(5, 7);
            this.lblRiverName.Name = "lblRiverName";
            this.lblRiverName.Size = new System.Drawing.Size(35, 13);
            this.lblRiverName.TabIndex = 0;
            this.lblRiverName.Text = "Name";
            // 
            // cbxRiverLand
            // 
            this.cbxRiverLand.FormattingEnabled = true;
            this.cbxRiverLand.Location = new System.Drawing.Point(93, 30);
            this.cbxRiverLand.Name = "cbbRiverLand";
            this.cbxRiverLand.Size = new System.Drawing.Size(116, 21);
            this.cbxRiverLand.TabIndex = 10;
            this.cbxRiverLand.DropDown += new System.EventHandler(this.cbbRiverLand_DropDown);
            // 
            // FieldsControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlStartEnd);
            this.Controls.Add(this.pnlRoute);
            this.Controls.Add(this.pnlRiver);
            this.Name = "FieldsControll";
            this.Size = new System.Drawing.Size(472, 557);
            this.pnlStartEnd.ResumeLayout(false);
            this.pnlStartEnd.PerformLayout();
            this.pnlRoute.ResumeLayout(false);
            this.pnlRoute.PerformLayout();
            this.pnlRiver.ResumeLayout(false);
            this.pnlRiver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRouteWWLevel;
        private System.Windows.Forms.Label lblStartEndeEnd;
        private System.Windows.Forms.Label lblStartEndeStart;
        private System.Windows.Forms.Label lblRouteStart;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblRouteEnd;
        private System.Windows.Forms.Label lblRouteComment;
        private System.Windows.Forms.Label lblRiverTicketPricer;
        private System.Windows.Forms.Label lblRiverTicket;
        private System.Windows.Forms.Label lblRiverWWLevel;
        private System.Windows.Forms.Label lblRiverLand;
        private System.Windows.Forms.Label lblRiverName;
        private System.Windows.Forms.Panel pnlStartEnd;
        private System.Windows.Forms.Panel pnlRoute;
        private System.Windows.Forms.Panel pnlRiver;
        private System.Windows.Forms.TextBox txtStartEndName;
        private System.Windows.Forms.TextBox txtRouteWWLevel;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.TextBox txtRouteComment;
        private System.Windows.Forms.CheckBox chkRiverTicket;
        private System.Windows.Forms.TextBox txtRiverTicketPrice;
        private System.Windows.Forms.TextBox txtRiverWWLevel;
        private System.Windows.Forms.TextBox txtRiverName;
        private System.Windows.Forms.Label lblRouteRiver;
        private System.Windows.Forms.ComboBox cbxRouteRiver;
        private System.Windows.Forms.TextBox txtStartEndLand;
        private System.Windows.Forms.Label lblStartEndLand;
        private System.Windows.Forms.Label lblStartEndCoordinates;
        private System.Windows.Forms.CheckBox chkStartEndStart;
        private System.Windows.Forms.CheckBox chkStartEndEnd;
        private System.Windows.Forms.ComboBox cbxRouteStart;
        private System.Windows.Forms.ComboBox cbxRouteEnd;
        private System.Windows.Forms.MaskedTextBox mtxtStartEndCoordinates;
        private System.Windows.Forms.ComboBox cbxRiverLand;
    }
}
