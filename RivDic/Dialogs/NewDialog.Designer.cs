namespace RivDic.Dialogs
{
    partial class NewDialog
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
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.fieldsControll = new RivDic.Dialogs.FieldsControll();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(155, 3);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abbruch";
            this.btnAbort.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(74, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnAbort);
            this.pnlButtons.Controls.Add(this.btnOk);
            this.pnlButtons.Location = new System.Drawing.Point(9, 221);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(233, 30);
            this.pnlButtons.TabIndex = 2;
            // 
            // fieldsControll
            // 
            this.fieldsControll.Location = new System.Drawing.Point(13, 13);
            this.fieldsControll.Name = "fieldsControll";
            this.fieldsControll.Size = new System.Drawing.Size(220, 200);
            this.fieldsControll.TabIndex = 3;
            // 
            // NewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 260);
            this.Controls.Add(this.fieldsControll);
            this.Controls.Add(this.pnlButtons);
            this.Name = "NewDialog";
            this.ShowInTaskbar = false;
            this.Text = "NewDialog";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlButtons;
        private FieldsControll fieldsControll;
    }
}