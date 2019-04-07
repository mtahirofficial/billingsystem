using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Billing_System.User_Controls
{
    public partial class ViewInvioces : UserControl
    {
        private static ViewInvioces _instance;
        public static ViewInvioces Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ViewInvioces();
                }
                return _instance;
            }
        }
        public ViewInvioces()
        {
            InitializeComponent();
        }

        SqlConnection cmdConnection;
        SqlCommand cmdSelect;
        SqlCommand cmdUpdate;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        private double sum;

        public string TotalPrice(string varQuantity, string varUnitPrice)
        {
            double varNewQuantity = Convert.ToDouble(varQuantity);
            double varNewUnitPrice = Convert.ToDouble(varUnitPrice);
            double varTotalPrice = varNewQuantity * varNewUnitPrice;
            string varTotalpriceS = Convert.ToString(varTotalPrice);
            return varTotalpriceS;
        }

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
                else
                {
                    MessageBox.Show("Record Not Found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                reader.Close();
                dgvInvoice.DataSource = null;
                dgvInvoice.Visible = false;
                dgvInvoice.SendToBack();
                //btnUpdate.Enabled = false;
                btnBack.Enabled = false;
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
                else
                {
                    MessageBox.Show("Record Not Found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                reader.Close();
                dgvInvoice.DataSource = null;
                dgvInvoice.Visible = false;
                dgvInvoice.SendToBack();
                //btnUpdate.Enabled = false;
                btnBack.Enabled = false;
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
                else
                {
                    MessageBox.Show("Record Not Found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                reader.Close();
                dgvInvoice.DataSource = null;
                dgvInvoice.Visible = false;
                dgvInvoice.SendToBack();
                //btnUpdate.Enabled = false;
                btnBack.Enabled = false;
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
            reader.Close();
            btnBack.Enabled = false;
            //btnUpdate.Enabled = false;
            dgvInvoice.Visible = false;
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


        static string invoiceNo;
        private void viewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            //btnUpdate.Enabled = true;

            int rowIndex = dgvInvoiceList.SelectedRows[0].Index;
            DataGridViewRow row = this.dgvInvoiceList.SelectedRows[0];

            invoiceNo = row.Cells[0].Value.ToString();
            string phoneNo = row.Cells[2].Value.ToString();

            try
            {
                string path = Application.StartupPath + "\\invoices\\";
                string fullPath = @path + phoneNo + ".pdf";
                System.Diagnostics.Process.Start(fullPath);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

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
                dgvInvoice.DataSource = dataSet.Tables["invoiceListFull"].DefaultView;
                dgvInvoice.Visible = true;
                dgvInvoice.BringToFront();
            } else
            {
                MessageBox.Show("No Data is Available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reader.Close();
        }

        private void dgvInvoiceList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvInvoiceList.Rows.Count > 0)
                {
                    var ht = dgvInvoiceList.HitTest(e.X, e.Y);
                    dgvInvoiceList.ClearSelection();
                    dgvInvoiceList.Rows[ht.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvInvoiceList, e.X, e.Y);
                    editToolStripMenuItem.Visible = false;
                    viewInvoiceToolStripMenuItem.Visible = true;
                }

            }

        }

        private void dgvInvoiceList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvInvoiceList.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = null;
            dgvInvoice.Visible = false;
            dgvInvoice.SendToBack();
            //btnUpdate.Enabled = false;
            btnBack.Enabled = false;

        }

        private void dgvInvoice_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvInvoice.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }



        // Update from gridview
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int rowIndex = dgvInvoice.CurrentCell.RowIndex;
        //    if (cmdConnection.State == ConnectionState.Closed)
        //    {
        //        cmdConnection.Open();
        //    }

        //    SqlCommand cmdDelete = new SqlCommand("delete from ShopInvoice where InvoiceNo = '" + invoiceNo + "'", cmdConnection);
        //    SqlDataReader delReader = cmdDelete.ExecuteReader();
        //    delReader.Close();
            
        //    if (dgvInvoice.Rows.Count >= 1)
        //    {
        //        foreach (DataGridViewRow row in dgvInvoice.Rows)
        //        {
        //            SqlCommand cmdInsert = new SqlCommand("Insert into ShopInvoice (InvoiceNo, SerialNo, Product, Quantity, BatchNo, UnitPrice, TotalPrice, Date) values ('" + invoiceNo + "','" + row.Cells[0].Value + "','" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "','" + row.Cells[5].Value + "','" + row.Cells[6].Value + "')", cmdConnection);
        //            cmdInsert.ExecuteNonQuery();
        //            //SqlCommand cmdUpdate = new SqlCommand("Update MedicineStock set Quantity = '" + row.Cells[2].Value + "' where MedicineName = '" + row.Cells[1].Value + "'", cmdConnection);
        //            //cmdUpdate.ExecuteNonQuery();

        //            MessageBox.Show("0:" + row.Cells[0].Value + "   1:" + row.Cells[1].Value + "   2:" + row.Cells[2].Value + "   3:" + row.Cells[3].Value + "   4:" + row.Cells[4].Value + "   5:" + row.Cells[5].Value + "   6:" + row.Cells[6].Value, "Test DatagridView", MessageBoxButtons.OK);
        //        }
        //    }
            
        //    SqlCommand cmdSelect = new SqlCommand("select * from ShopInvoice where InvoiceNo = '" + invoiceNo + "'", cmdConnection);
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
        //    DataSet dataSet = new DataSet();
        //    SqlDataReader reader = cmdSelect.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        reader.Close();
        //        dataAdapter.Fill(dataSet, "invoiceList");
        //        dgvInvoice.DataSource = dataSet.Tables["invoiceList"].DefaultView;
        //    }
        //    else
        //    {
        //        MessageBox.Show("There is no stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        dgvInvoice.DataSource = null;
        //        //txtMediName.Focus();
        //    }
        //    reader.Close();

        //}

        private void dgvInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvInvoiceList.Rows.Count > 0)
                {
                    dgvInvoiceList.ClearSelection();
                    var ht = dgvInvoice.HitTest(e.X, e.Y);
                    dgvInvoice.Rows[ht.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvInvoice, e.X, e.Y);
                    viewInvoiceToolStripMenuItem.Visible = false;
                    editToolStripMenuItem.Visible = true;
                    
                }

            }

            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            //int rowIndex = dgvInvoice.SelectedRows[0].Index;
            //DataGridViewRow row = this.dgvInvoice.SelectedRows[0];

            //invoiceNo = row.Cells[0].Value.ToString();
            //txtSrNo.Text = dgvInvoice.Rows[rowIndex].Cells[0].Value.ToString();
            //txtMedi.Text = dgvInvoice.Rows[rowIndex].Cells[1].Value.ToString();
            //txtQty.Text = dgvInvoice.Rows[rowIndex].Cells[2].Value.ToString();
            //txtBatch.Text = dgvInvoice.Rows[rowIndex].Cells[3].Value.ToString();
            //txtRate.Text = dgvInvoice.Rows[rowIndex].Cells[4].Value.ToString();
            //txtPrice.Text = dgvInvoice.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void lblBatch_Click(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            //if (txtQty.Text != "" && txtRate.Text != "")
            //{
            //    txtPrice.Text = TotalPrice(txtQty.Text, txtRate.Text);
            //}
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            //if (txtQty.Text != "" && txtRate.Text != "")
            //{
            //    txtPrice.Text = TotalPrice(txtQty.Text, txtRate.Text);
            //}
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only integer value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    btnSave.PerformClick();
            //}
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                MessageBox.Show("Only numeric value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    btnSave.PerformClick();
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmdConnection.State == ConnectionState.Closed)
            {
                cmdConnection.Open();
            }
            //if (txtMedi.Text.Trim() == "" && txtQty.Text.Trim() == "" && txtBatch.Text.Trim() == "" && txtRate.Text.Trim() == "")
            //{
            //    MessageBox.Show("All Fields are Required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMedi.Focus();
            //}

            //else if (txtMedi.Text.Trim() == "")
            //{
            //    MessageBox.Show("NMedicine Name is Required.", "Medicine Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMedi.Focus();
            //}
            //else if (txtBatch.Text.Trim() == "")
            //{
            //    MessageBox.Show("Batch No. is Required.", "Batch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtBatch.Focus();
            //}
            //else if (txtQty.Text.Trim() == "")
            //{
            //    MessageBox.Show("Quantity is Required.", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtQty.Focus();
            //}

            //else if (txtRate.Text.Trim() == "")
            //{
            //    MessageBox.Show("Rate is Required.", "Rate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtRate.Focus();
            //}
            //else
            //{

            //    try
            //    {
            //        cmdUpdate = new SqlCommand("UPDATE ShopInvoice SET Product = '" + txtMedi.Text.Trim() + "', BatchNo = '" + txtBatch.Text.Trim() + "', Quantity = '" + txtQty.Text.Trim() + "', UnitPrice = '" + txtRate.Text.Trim() + "', TotalPrice = '" + txtPrice.Text.Trim() + "' where SerialNo = '" + txtSrNo.Text.Trim() + "' AND InvoiceNo = '"+ invoiceNo +"'", cmdConnection);
            //        cmdUpdate.ExecuteNonQuery();

                    


            //        SqlCommand cmdSelect = new SqlCommand("Select SerialNo, Product, Quantity, BatchNo, UnitPrice, TotalPrice, Date From ShopInvoice Where InvoiceNo = '" + invoiceNo + "'", cmdConnection);
            //        dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, cmdConnection);
            //        dataSet = new DataSet();
            //        SqlDataReader reader = cmdSelect.ExecuteReader();
            //        if (reader.Read())
            //        {
            //            reader.Close();
            //            dataAdapter.Fill(dataSet, "invoiceListFull");
            //            dgvInvoice.DataSource = dataSet.Tables["invoiceListFull"].DefaultView;
            //            dgvInvoice.Visible = true;
            //            dgvInvoice.BringToFront();
            //        }
            //        else
            //        {
            //            MessageBox.Show("No Data is Available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        reader.Close();
            //        foreach (DataGridViewRow row in dgvInvoice.Rows)
            //        {
            //            sum += Convert.ToDouble(row.Cells[5].Value);
            //        }
            //        cmdUpdate = new SqlCommand("UPDATE ShopAmount SET TotalAmount = '" + sum + "' where InvoiceNo = '" + invoiceNo + "'", cmdConnection);
            //        cmdUpdate.ExecuteNonQuery();
            //        sum = 0;



            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

                //string strSrNo = txtSrNo.Text;
                //txtMedi.Text = "0";
                //txtQty.Clear();
                //txtSrNo.Text = Convert.ToString(Convert.ToInt32(strSrNo) + 1);
                //txtMedi.Focus();
                //txtPrice.Text = "0";
            //}
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
