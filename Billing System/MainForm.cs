using Billing_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing_System.User_Controls;

namespace Billing_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close application ?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            pnlHead.GradientBottomLeft = Color.White;
            pnlHead.GradientBottomRight = Color.White;
            pnlHead.GradientTopLeft = Color.White;
            pnlHead.GradientTopRight = Color.White;
            btnClose.BackColor = Color.White;
            btnMaximize.BackColor = Color.White;
            btnMinimize.BackColor = Color.White;
            btnRestore.BackColor = Color.White;
            picBoxLogo.BackColor = Color.White;
            lblCompanyName.BackColor = Color.White; 
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            pnlHead.GradientBottomLeft = Color.Gainsboro;
            pnlHead.GradientBottomRight = Color.Gainsboro;
            pnlHead.GradientTopLeft = Color.Gainsboro;
            pnlHead.GradientTopRight = Color.Gainsboro;
            btnClose.BackColor = Color.Gainsboro;
            btnMaximize.BackColor = Color.Gainsboro;
            btnMinimize.BackColor = Color.Gainsboro;
            btnRestore.BackColor = Color.Gainsboro;
            picBoxLogo.BackColor = Color.Gainsboro;
            lblCompanyName.BackColor = Color.Gainsboro;
        }

        private void pnlHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void lblCompanyName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void lblCompanyName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void lblDeveloperLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/FMDevelopersAndDesigners");
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpers.forgotpass = "";
            login1.BringToFront();
            lblLogin.Visible = false;
            lblSignUp.Visible = true;
        }

        private void lblViewInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewInvioces1.BringToFront();
            lblLogin.Visible = false;
            lblSignUp.Visible = false;
        }

        private void lblInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            shopInvoice1.ClearTextBoxes();
            shopInvoice1.medicineList.Clear();
            shopInvoice2.BringToFront();
            lblLogin.Visible = false;
            lblSignUp.Visible = false;
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            home1.BringToFront();
            //login1.BringToFront();

            //lblInvoice.Visible = false;
            //lblViewInvoice.Visible = false;
            //lblNewMedicine.Visible = false;
            //lblMedicineStock.Visible = false;
            //lblSignout.Visible = false;
            //lblSignUp.Visible = true;

            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestore.BringToFront();
            }
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup1.BringToFront();
            lblLogin.Visible = true;
            lblSignUp.Visible = false;
        }

        private void lblSignout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home1.BringToFront();
            login1.BringToFront();
            helpers.LoggedUser = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newMedicine1.BringToFront();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewStock1.BringToFront();
        }

        

        private void newMedicine1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (helpers.LoggedUser != "")
            {
                lblInvoice.Visible = true;
                lblViewInvoice.Visible = true;
                lblNewMedicine.Visible = true;
                lblMedicineStock.Visible = true;
                lblSignout.Visible = true;
                lblSignUp.Visible = false;
                lblLogin.Visible = false;
            } else
            {
                lblInvoice.Visible = false;
                lblViewInvoice.Visible = false;
                lblNewMedicine.Visible = false;
                lblMedicineStock.Visible = false;
                lblSignout.Visible = false;
                lblSignUp.Visible = true;
                lblLogin.Visible = true;
            }
            if (helpers.forgotpass == "yes")
            {
                forgottPass1.BringToFront();
            }
        }
    }
}
