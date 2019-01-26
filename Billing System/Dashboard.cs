using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection objConnection = new SqlConnection(SystemFunctions.ConnectionString());
        


        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void recLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void BtnCompany_Click(object sender, EventArgs e)
        {
            SupplyInvoice supply = new SupplyInvoice();
            supply.Show();
            this.Hide();
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            ShopInvoice shop = new ShopInvoice();
            shop.Show();
            this.Hide();
        }
    }
}
