using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SQLiteConnection objConnectionLogin;
        SQLiteCommand objSelectCmd;
        
        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
        
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("User Name & Password Must Required.", "Message", MessageBoxButtons.OK);
                txtUserName.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("User Name is Required.", "Message", MessageBoxButtons.OK);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is Required.", "Message", MessageBoxButtons.OK);
                txtPassword.Focus();
            }

            else
            {

                objSelectCmd = new SQLiteCommand(
                    "select * from Login where User_Name = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'",
                    objConnectionLogin);
                
                objConnectionLogin.Open();
                try
                {
                    SQLiteDataReader objReader = objSelectCmd.ExecuteReader();
                    {
                        if (objReader.Read())
                        {
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                            
                        }
                        objReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    objConnectionLogin.Close();
                }
                
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            objConnectionLogin = new SQLiteConnection(SystemFunctions.ConnectionString());
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPass = new ForgotPassword();
            forgotPass.Show();
            this.Hide();
        }
    }
}
