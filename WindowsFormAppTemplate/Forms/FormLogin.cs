using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManager;

namespace WindowsFormAppTemplate.Forms
{
    public partial class FormLogin : Form
    {

        private List<DatabaseManager.EntityClasses.User> databaseUsers;
        private DatabaseHandler databaseManager;

        public bool LoginSuccessful() 
        { 
            return _loginSuccessful; 
        }
        private bool _loginSuccessful = false;

        public FormLogin()
        {
            InitializeComponent();
            CustomInitialization();
            CenterToScreen();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void CustomInitialization()
        {
            this.Icon = new Icon("Icons/computer_30842_32x32.ico");
            btnLogin.Enabled = false;
            databaseManager = DatabaseHandler.GetInstance();
            databaseUsers = databaseManager.GetUsers();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            TextChanged();
        }

        private void TextChanged()
        {
            if ((txtUsername.Text.Length > 0) && (txtPassword.Text.Length > 0))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextChanged();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseManager.EntityClasses.User databaseUser = databaseUsers.Find(item => item.Username == txtUsername.Text);
            if (databaseUser != null) {
                if (txtPassword.Text == databaseUser.Password)
                {
                    _loginSuccessful = true;                    
                }
            }

            if (_loginSuccessful)
            {
                this.Close();
            }
            else 
            {
                DialogResult res = MessageBox.Show("Invalid username and/or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
