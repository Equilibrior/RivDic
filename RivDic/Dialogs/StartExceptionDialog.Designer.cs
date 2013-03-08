namespace RivDic.Dialogs
{
    partial class StartExceptionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartExceptionDialog));
            this.lblFirebirdStarted = new System.Windows.Forms.Label();
            this.lblDbFound = new System.Windows.Forms.Label();
            this.lblLoginSuccessfull = new System.Windows.Forms.Label();
            this.picLoginSuccessfull = new System.Windows.Forms.PictureBox();
            this.picDbFound = new System.Windows.Forms.PictureBox();
            this.picFirebirdStarted = new System.Windows.Forms.PictureBox();
            this.btnStartFirebird = new System.Windows.Forms.Button();
            this.btnSelectDbPath = new System.Windows.Forms.Button();
            this.btnEnterLoginData = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.pnlEnterLogin = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnAcceptLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginSuccessfull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDbFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirebirdStarted)).BeginInit();
            this.pnlCheck.SuspendLayout();
            this.pnlEnterLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirebirdStarted
            // 
            this.lblFirebirdStarted.AutoSize = true;
            this.lblFirebirdStarted.Location = new System.Drawing.Point(45, 8);
            this.lblFirebirdStarted.Name = "lblFirebirdStarted";
            this.lblFirebirdStarted.Size = new System.Drawing.Size(211, 13);
            this.lblFirebirdStarted.TabIndex = 0;
            this.lblFirebirdStarted.Text = "Der Firebird-Server Dienst ist nicht gestartet";
            // 
            // lblDbFound
            // 
            this.lblDbFound.AutoSize = true;
            this.lblDbFound.Location = new System.Drawing.Point(45, 37);
            this.lblDbFound.Name = "lblDbFound";
            this.lblDbFound.Size = new System.Drawing.Size(35, 13);
            this.lblDbFound.TabIndex = 2;
            this.lblDbFound.Text = "label2";
            // 
            // lblLoginSuccessfull
            // 
            this.lblLoginSuccessfull.AutoSize = true;
            this.lblLoginSuccessfull.Location = new System.Drawing.Point(45, 72);
            this.lblLoginSuccessfull.Name = "lblLoginSuccessfull";
            this.lblLoginSuccessfull.Size = new System.Drawing.Size(35, 13);
            this.lblLoginSuccessfull.TabIndex = 3;
            this.lblLoginSuccessfull.Text = "label3";
            // 
            // picLoginSuccessfull
            // 
            this.picLoginSuccessfull.Image = global::RivDic.Properties.Resources.Clean_16x16;
            this.picLoginSuccessfull.Location = new System.Drawing.Point(18, 69);
            this.picLoginSuccessfull.Name = "picLoginSuccessfull";
            this.picLoginSuccessfull.Size = new System.Drawing.Size(21, 20);
            this.picLoginSuccessfull.TabIndex = 6;
            this.picLoginSuccessfull.TabStop = false;
            // 
            // picDbFound
            // 
            this.picDbFound.Image = global::RivDic.Properties.Resources.Clean_16x16;
            this.picDbFound.Location = new System.Drawing.Point(19, 39);
            this.picDbFound.Name = "picDbFound";
            this.picDbFound.Size = new System.Drawing.Size(21, 16);
            this.picDbFound.TabIndex = 5;
            this.picDbFound.TabStop = false;
            // 
            // picFirebirdStarted
            // 
            this.picFirebirdStarted.Image = global::RivDic.Properties.Resources.Clean_16x16;
            this.picFirebirdStarted.Location = new System.Drawing.Point(19, 7);
            this.picFirebirdStarted.Name = "picFirebirdStarted";
            this.picFirebirdStarted.Size = new System.Drawing.Size(20, 18);
            this.picFirebirdStarted.TabIndex = 4;
            this.picFirebirdStarted.TabStop = false;
            // 
            // btnStartFirebird
            // 
            this.btnStartFirebird.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartFirebird.Location = new System.Drawing.Point(372, 2);
            this.btnStartFirebird.Name = "btnStartFirebird";
            this.btnStartFirebird.Size = new System.Drawing.Size(75, 23);
            this.btnStartFirebird.TabIndex = 7;
            this.btnStartFirebird.Text = "Starten";
            this.btnStartFirebird.UseVisualStyleBackColor = true;
            this.btnStartFirebird.Click += new System.EventHandler(this.btnStartFirebird_Click);
            // 
            // btnSelectDbPath
            // 
            this.btnSelectDbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDbPath.Location = new System.Drawing.Point(372, 32);
            this.btnSelectDbPath.Name = "btnSelectDbPath";
            this.btnSelectDbPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDbPath.TabIndex = 8;
            this.btnSelectDbPath.Text = "Auswählen";
            this.btnSelectDbPath.UseVisualStyleBackColor = true;
            this.btnSelectDbPath.Click += new System.EventHandler(this.btnSelectDbPath_Click);
            // 
            // btnEnterLoginData
            // 
            this.btnEnterLoginData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterLoginData.Location = new System.Drawing.Point(372, 66);
            this.btnEnterLoginData.Name = "btnEnterLoginData";
            this.btnEnterLoginData.Size = new System.Drawing.Size(75, 23);
            this.btnEnterLoginData.TabIndex = 9;
            this.btnEnterLoginData.Text = "Auswählen";
            this.btnEnterLoginData.UseVisualStyleBackColor = true;
            this.btnEnterLoginData.Click += new System.EventHandler(this.btnEnterLoginData_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(290, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(370, 96);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Schließen";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.picFirebirdStarted);
            this.pnlCheck.Controls.Add(this.btnSelectDbPath);
            this.pnlCheck.Controls.Add(this.btnStartFirebird);
            this.pnlCheck.Controls.Add(this.btnExit);
            this.pnlCheck.Controls.Add(this.lblFirebirdStarted);
            this.pnlCheck.Controls.Add(this.btnStart);
            this.pnlCheck.Controls.Add(this.lblDbFound);
            this.pnlCheck.Controls.Add(this.btnEnterLoginData);
            this.pnlCheck.Controls.Add(this.lblLoginSuccessfull);
            this.pnlCheck.Controls.Add(this.picDbFound);
            this.pnlCheck.Controls.Add(this.picLoginSuccessfull);
            this.pnlCheck.Location = new System.Drawing.Point(2, 2);
            this.pnlCheck.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(450, 122);
            this.pnlCheck.TabIndex = 12;
            // 
            // pnlEnterLogin
            // 
            this.pnlEnterLogin.Controls.Add(this.lblPassword);
            this.pnlEnterLogin.Controls.Add(this.lblUser);
            this.pnlEnterLogin.Controls.Add(this.btnAcceptLogin);
            this.pnlEnterLogin.Controls.Add(this.txtPassword);
            this.pnlEnterLogin.Controls.Add(this.txtUser);
            this.pnlEnterLogin.Location = new System.Drawing.Point(2, 128);
            this.pnlEnterLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEnterLogin.Name = "pnlEnterLogin";
            this.pnlEnterLogin.Size = new System.Drawing.Size(189, 103);
            this.pnlEnterLogin.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(2, 28);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Passwort";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(2, 6);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Benutzer";
            // 
            // btnAcceptLogin
            // 
            this.btnAcceptLogin.Location = new System.Drawing.Point(130, 49);
            this.btnAcceptLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptLogin.Name = "btnAcceptLogin";
            this.btnAcceptLogin.Size = new System.Drawing.Size(56, 19);
            this.btnAcceptLogin.TabIndex = 2;
            this.btnAcceptLogin.Text = "Ok";
            this.btnAcceptLogin.UseVisualStyleBackColor = true;
            this.btnAcceptLogin.Click += new System.EventHandler(this.btnAcceptLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 26);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(116, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.AcceptsTab = true;
            this.txtUser.Location = new System.Drawing.Point(72, 3);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(116, 20);
            this.txtUser.TabIndex = 0;
            // 
            // StartExceptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 126);
            this.Controls.Add(this.pnlEnterLogin);
            this.Controls.Add(this.pnlCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartExceptionDialog";
            this.Text = "StartExceptionDialog";
            ((System.ComponentModel.ISupportInitialize)(this.picLoginSuccessfull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDbFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirebirdStarted)).EndInit();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlEnterLogin.ResumeLayout(false);
            this.pnlEnterLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirebirdStarted;
        private System.Windows.Forms.Label lblDbFound;
        private System.Windows.Forms.Label lblLoginSuccessfull;
        private System.Windows.Forms.PictureBox picFirebirdStarted;
        private System.Windows.Forms.PictureBox picDbFound;
        private System.Windows.Forms.PictureBox picLoginSuccessfull;
        private System.Windows.Forms.Button btnStartFirebird;
        private System.Windows.Forms.Button btnSelectDbPath;
        private System.Windows.Forms.Button btnEnterLoginData;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlCheck;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnAcceptLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlEnterLogin;

    }
}