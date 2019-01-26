using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Billing_System.User_Controls
{
    public partial class ViewInvioces : UserControl
    {
        public ViewInvioces()
        {
            InitializeComponent();
        }

        SqlConnection cmdConnection;
        SqlCommand cmdSelect;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text == "" && txtPhoneNo.Text == "")
            {
                MessageBox.Show("Enter Invoice Number or Phone Number.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInvoiceNo.Focus();
            }
            else if (txtInvoiceNo.Text != "" && txtPhoneNo.Text == "")
            {
                if (cmdConnection.State == ConnectionState.Closed)
                {
                    cmdConnection.Open();
                }
                // search Invoice
                cmdSelect = new SqlCommand("Select ShopCustomer.InvoiceNo, ShopCustomer.CustomerName, ShopCustomer.Mobile, ShopAmount.TotalAmount From ShopCustomer inner join ShopAmount on ShopCustomer.InvoiceNo=ShopAmount.InvoiceNo Where ShopCustomer.InvoiceNo = '" + txtInvoiceNo.Text.Trim() + "'", cmdConnection);
                dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
                dataSet = new DataSet();
                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    dataAdapter.Fill(dataSet, "invoiceList");
                    dgvInvoiceList.DataSource = dataSet.Tables["invoiceList"].DefaultView;
                }
            }
            else if (txtPhoneNo.Text != "" && txtInvoiceNo.Text == "")
            {
                if (cmdConnection.State == ConnectionState.Closed)
                {
                    cmdConnection.Open();
                }
                //Search Phone
                cmdSelect = new SqlCommand("Select ShopCustomer.InvoiceNo, ShopCustomer.CustomerName, ShopCustomer.Mobile, ShopAmount.TotalAmount From ShopCustomer inner join ShopAmount on ShopCustomer.InvoiceNo=ShopAmount.InvoiceNo Where ShopCustomer.Mobile = '" + txtPhoneNo.Text.Trim() + "'", cmdConnection);
                dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
                dataSet = new DataSet();
                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    dataAdapter.Fill(dataSet, "invoiceList");
                    dgvInvoiceList.DataSource = dataSet.Tables["invoiceList"].DefaultView;
                }
            }
            else
            {
                // Search Phone & Invoice
                cmdSelect = new SqlCommand("Select ShopCustomer.InvoiceNo, ShopCustomer.CustomerName, ShopCustomer.Mobile, ShopAmount.TotalAmount From ShopCustomer inner join ShopAmount on ShopCustomer.InvoiceNo=ShopAmount.InvoiceNo Where ShopCustomer.Mobile = '" + txtPhoneNo.Text.Trim() + "' and ShopCustomer.InvoiceNo = '" + txtInvoiceNo.Text.Trim() + "'", cmdConnection);
                dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
                dataSet = new DataSet();
                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    dataAdapter.Fill(dataSet, "invoiceList");
                    dgvInvoiceList.DataSource = dataSet.Tables["invoiceList"].DefaultView;
                }
                reader.Close();
            }

        }

        private void ViewInvioces_Load(object sender, EventArgs e)
        {
            cmdConnection = new SqlConnection(SystemFunctions.ConnectionString());

            if (cmdConnection.State == ConnectionState.Closed)
            {
                cmdConnection.Open();
            }
            cmdSelect = new SqlCommand("Select ShopCustomer.InvoiceNo, ShopCustomer.CustomerName, ShopCustomer.Mobile, ShopAmount.TotalAmount From ShopCustomer inner join ShopAmount on ShopCustomer.InvoiceNo=ShopAmount.InvoiceNo", cmdConnection);
            dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
            dataSet = new DataSet();
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                dataAdapter.Fill(dataSet, "invoiceListFull");
                dgvInvoiceList.DataSource = dataSet.Tables["invoiceListFull"].DefaultView;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (cmdConnection.State == ConnectionState.Closed)
            {
                cmdConnection.Open();
            }
            cmdSelect = new SqlCommand("Select ShopCustomer.InvoiceNo, ShopCustomer.CustomerName, ShopCustomer.Mobile, ShopAmount.TotalAmount From ShopCustomer inner join ShopAmount on ShopCustomer.InvoiceNo=ShopAmount.InvoiceNo", cmdConnection);
            dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
            dataSet = new DataSet();
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                dataAdapter.Fill(dataSet, "invoiceListFull");
                dgvInvoiceList.DataSource = dataSet.Tables["invoiceListFull"].DefaultView;
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numeric value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numeric value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        private int dataGridViewHeight()
        {
            int sum = this.dgvInvoiceList.ColumnHeadersHeight;

            foreach (DataGridViewRow row in this.dgvInvoiceList.Rows)
                sum += row.Height + 1; // I dont think the height property includes the cell border size, so + 1

            return sum;
        }



        private void viewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvInvoiceList.SelectedRows[0].Index;
            //MessageBox.Show("Selected Row Index is " + rowIndex.ToString() + ".", "test");
            DataGridViewRow row = this.dgvInvoiceList.SelectedRows[0];
            //MessageBox.Show("Selected Values is " + row.Cells["colInvoiceNo"].Value);

            string invoiceNo = row.Cells[0].Value.ToString();
            if (cmdConnection.State == ConnectionState.Closed)
            {
                cmdConnection.Open();
            }
            SqlCommand cmdSelect = new SqlCommand("Select SerialNo, Product, Quantity, BatchNo, UnitPrice, TotalPrice, Date From ShopInvoice Where InvoiceNo = '" + invoiceNo + "'", cmdConnection);
            dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
            dataSet = new DataSet();
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                dataAdapter.Fill(dataSet, "invoiceListFull");
                dgvInvoiceList.DataSource = dataSet.Tables["invoiceListFull"].DefaultView;
            }
        }

        private void dgvInvoiceList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ht = dgvInvoiceList.HitTest(e.X, e.Y);
                dgvInvoiceList.Rows[ht.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvInvoiceList, e.X, e.Y);
            }
        }

        private void dgvInvoiceList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvInvoiceList.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
