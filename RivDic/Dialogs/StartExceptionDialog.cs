using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Configuration;
using System.Diagnostics;
using RivDic.Properties;

namespace RivDic.Dialogs
{
    /// ============================================================================================================================
    public partial class StartExceptionDialog : Form
    {

        #region Konstruktor

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        public StartExceptionDialog()
        {
            InitializeComponent();
            Initialize();
            CheckRequirements();
        }

        #endregion Konstruktor

        #region Properties

        private LoginResult loginrslt;

        #endregion Properties

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Initialisiert den Dialog.
        /// </summary>
        private void Initialize()
        {
            picFirebirdStarted.Image = Resources.Error_16x16;
            lblFirebirdStarted.Text = Resources.txtFirebirdNotStarted;
            picDbFound.Image = Resources.Error_16x16;
            lblDbFound.Text = Resources.txtDbNotFound;
            picLoginSuccessfull.Image = Resources.Error_16x16;
            lblLoginSuccessfull.Text = Resources.txtLoginNotSuccessfull;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Prüft die Anforderungen für ein Login in die Datenbank
        /// </summary>
        private void CheckRequirements()
        {
            switch (loginrslt)
            {
                case LoginResult.FirebirdNotStarted:
                    {
                        picFirebirdStarted.Image = Resources.Error_16x16;
                        lblFirebirdStarted.Text = Resources.txtFirebirdNotStarted;
                        break;
                    }
                case LoginResult.DatabaseNotFound:
                    {
                        picFirebirdStarted.Image = Resources.Clean_16x16;
                        lblFirebirdStarted.Text = Resources.txtFirebirdStarted;
                        picDbFound.Image = Resources.Error_16x16;
                        lblDbFound.Text = Resources.txtDbNotFound;
                        break;
                    }
                case LoginResult.LoginDataIncorrect:
                    {
                        picFirebirdStarted.Image = Resources.Clean_16x16;
                        lblFirebirdStarted.Text = Resources.txtFirebirdStarted;
                        picDbFound.Image = Resources.Clean_16x16;
                        lblDbFound.Text = Resources.txtDbFound;
                        picLoginSuccessfull.Image = Resources.Error_16x16;
                        lblLoginSuccessfull.Text = Resources.txtLoginNotSuccessfull;
                        break;
                    }
                case LoginResult.Successfull:
                    {
                        picFirebirdStarted.Image = Resources.Clean_16x16;
                        lblFirebirdStarted.Text = Resources.txtFirebirdStarted;
                        picDbFound.Image = Resources.Clean_16x16;
                        lblDbFound.Text = Resources.txtDbFound;
                        picLoginSuccessfull.Image = Resources.Clean_16x16;
                        lblLoginSuccessfull.Text = Resources.txtLoginSuccessfull;
                        break;
                    }
                case LoginResult.ConnectionStringArgumentError:
                case LoginResult.Error:
                default:
                    {
                        picFirebirdStarted.Image = Resources.Clean_16x16;
                        lblFirebirdStarted.Text = Resources.txtFirebirdStarted;
                        picDbFound.Image = Resources.Error_16x16;
                        lblDbFound.Text = Resources.txtDbNotFound;
                        picLoginSuccessfull.Image = Resources.Error_16x16;
                        lblLoginSuccessfull.Text = Resources.txtLoginNotSuccessfull;
                        break;
                    }
            }
        }

        private void btnStartFirebird_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void btnSelectDbPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog.FileName))
                Database.WriteSettings(Constants.DbPath, openFileDialog.FileName);
        }

        private void btnEnterLoginData_Click(object sender, EventArgs e)
        {
            pnlEnterLogin.Visible = true;
            pnlCheck.Visible = false;
            pnlEnterLogin.Location = pnlCheck.Location;
        }

        private void btnAcceptLogin_Click(object sender, EventArgs e)
        {
            Database.WriteSettings(Constants.DbUser, txtUser.Text.ToString());
            Database.WriteSettings(Constants.DbPassword, txtPassword.Text.ToString());
            pnlEnterLogin.Visible = false;
            pnlCheck.Visible = true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------    
        /// <summary>
        /// Führt ein Login durch und öffnet je nach ergebnis den Checkdialog
        /// </summary>
        /// <returns>DialogResult basierend auf dem Ergebnis des Logins</returns>
        public DialogResult ShowCheckDialog()
        {
            loginrslt = Database.DatabaseLogin();
            if (loginrslt == LoginResult.Successfull)
                return DialogResult.OK;
            CheckRequirements();
            return ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            loginrslt = Database.DatabaseLogin();
            if (loginrslt.Equals(LoginResult.Successfull))
                DialogResult = DialogResult.OK;
            else
                CheckRequirements();
        }


        #endregion Methoden

    }
}
