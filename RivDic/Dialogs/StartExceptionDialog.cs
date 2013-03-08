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
            CheckRequirements(null, null, null);
        }

        #endregion Konstruktor

        #region Properties

        private LoginResult loginrslt;

        #endregion Properties

        #region Methoden

        private void CheckRequirements(string firebirdNotStarted, string dbNotFound, string loginDataIncorrect)
        {
            Boolean isFirebirdNotStarted;
            Boolean isDBNotFound;
            Boolean isLoginDataIncorrect;
            if (String.IsNullOrEmpty(firebirdNotStarted))
                isFirebirdNotStarted = loginrslt == LoginResult.FirebirdNotStarted;
            else
                isFirebirdNotStarted = Convert.ToBoolean(firebirdNotStarted);
            if (String.IsNullOrEmpty(dbNotFound))
                isDBNotFound = loginrslt == LoginResult.DatabaseNotFound;
            else
                isDBNotFound = Convert.ToBoolean(dbNotFound);
            if (String.IsNullOrEmpty(loginDataIncorrect))
                isLoginDataIncorrect = loginrslt == LoginResult.LoginDataIncorrect;
            else
                isLoginDataIncorrect = Convert.ToBoolean(loginDataIncorrect);

            if (isFirebirdNotStarted)
            {
                picFirebirdStarted.Image = Properties.Resources.Error_16x16;
                lblFirebirdStarted.Text = Properties.Resources.txtFirebirdNotStarted;
            }
            else
            {
                picFirebirdStarted.Image = Properties.Resources.Clean_16x16;
                lblFirebirdStarted.Text = Properties.Resources.txtFirebirdStarted;
            }

            if (isDBNotFound)
            {
                picDbFound.Image = Properties.Resources.Error_16x16;
                lblDbFound.Text = Properties.Resources.txtDbNotFound;
            }
            else
            {
                picDbFound.Image = Properties.Resources.Clean_16x16;
                lblDbFound.Text = Properties.Resources.txtDbFound;
            }

            if (isLoginDataIncorrect)
            {
                picLoginSuccessfull.Image = Properties.Resources.Error_16x16;
                lblLoginSuccessfull.Text = Properties.Resources.txtLoginNotSuccessfull;
            }
            else
            {
                picLoginSuccessfull.Image = Properties.Resources.Clean_16x16;
                lblLoginSuccessfull.Text = Properties.Resources.txtLoginSuccessfull;
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
            CheckRequirements(null, null, null);
            return ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            loginrslt = Database.DatabaseLogin();
            if (loginrslt.Equals(LoginResult.Successfull))
                DialogResult = DialogResult.OK;
            else
                CheckRequirements(null, null, null);
        }


        #endregion Methoden

    }
}
