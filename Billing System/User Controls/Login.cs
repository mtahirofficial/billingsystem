using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace Billing_System.User_Controls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection objConnectionLogin;
        SqlCommand objSelectCmd;

        private void picBoxShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.PasswordChar = '\0';
                picBoxHide.BringToFront();
                
            }
            
        }

        private void picBoxHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            picBoxShow.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Email & Password Must Required.", "Message", MessageBoxButtons.OK);
                txtEmail.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is Required.", "Message", MessageBoxButtons.OK);
                txtEmail.Focus();
            }
            else if (!(new EmailAddressAttribute().IsValid(txtEmail.Text)))
            {
                MessageBox.Show("Invalid Email.", "Message", MessageBoxButtons.OK);
                txtPassword.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is Required.", "Message", MessageBoxButtons.OK);
                txtPassword.Focus();
            }
            else
            {
                objConnectionLogin.Open();

                objSelectCmd = new SqlCommand(
                    "select * from Login where User_Name = '" + txtEmail.Text + "' and Password = '" + txtPassword.Text + "'",
                    objConnectionLogin);

                try
                {

                    SqlDataReader objReader = objSelectCmd.ExecuteReader();
                    {
                        if (objReader.Read())
                        {
                            //MessageBox.Show(this.Parent.Name);
                            helpers.LoggedUser = txtEmail.Text;
                            //MessageBox.Show(LoginInfo.LoggedUser);
                            this.SendToBack();


                        }
                        else
                        {
                            MessageBox.Show("Userename or password is incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        objReader.Close();
                    }
                    txtEmail.Clear();
                    txtPassword.Clear();
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            objConnectionLogin = new SqlConnection(SystemFunctions.ConnectionString());

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.SendToBack();
            helpers.forgotpass = "yes";
        }

    }
}
