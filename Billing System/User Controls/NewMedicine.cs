using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Billing_System.Model;

namespace Billing_System.User_Controls
{
    public partial class NewMedicine : UserControl
    {
        private static NewMedicine _instance;
        public static NewMedicine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NewMedicine();
                }
                return _instance;
            }
        }
        public NewMedicine()
        {
            InitializeComponent();
            AutoCompleteMedicine();

        }
        SqlConnection conConnection;
        List<StockItems> medicineList = new List<StockItems>();

        SqlCommand cmdSearchMedicine;
        SqlDataReader reader;
        private string strMediName;

        void AutoCompleteMedicine()
        {
            conConnection = new SqlConnection(SystemFunctions.ConnectionString());
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }

            txtMediName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMediName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            cmdSearchMedicine = new SqlCommand("Select * from MedicineStock", conConnection);
            reader = cmdSearchMedicine.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    strMediName = reader["MedicineName"].ToString();
                    coll.Add(strMediName);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Close();
            txtMediName.AutoCompleteCustomSource = coll;
            conConnection.Close();
        }


        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void NewMedicine_Load(object sender, EventArgs e)
        {
            conConnection = new SqlConnection(SystemFunctions.ConnectionString());

            btnCancel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMediName.Text.Trim() == "" && txtQty.Text.Trim() == "" && txtBatch.Text.Trim() == "" && txtRate.Text.Trim() == "")
            {
                MessageBox.Show("All Fields are Required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMediName.Focus();
            }

            else if (txtMediName.Text.Trim() == "")
            {
                MessageBox.Show("NMedicine Name is Required.", "Medicine Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMediName.Focus();
            }
            else if (txtBatch.Text.Trim() == "")
            {
                MessageBox.Show("Batch No. is Required.", "Batch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBatch.Focus();
            }
            else if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Quantity is Required.", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
            }

            else if (txtRate.Text.Trim() == "")
            {
                MessageBox.Show("Rate is Required.", "Rate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
            }
            else
            {

                try
                {
                    StockItems medicine = new StockItems()
                    {
                        SrNo = Convert.ToInt32(txtSrNo.Text),
                        MedicineName = txtMediName.Text,
                        Batch = txtBatch.Text,
                        Quantity = Convert.ToInt32(txtQty.Text),
                        Rate = Convert.ToDecimal(txtRate.Text),
                        Date = DateTime.Now.ToShortDateString()
                    };
                    medicineList.Add(medicine);
                    dgvMediList.DataSource = null;
                    dgvMediList.DataSource = medicineList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string strSrNo = txtSrNo.Text;
                txtMediName.Clear(); txtBatch.Clear(); txtQty.Clear(); txtRate.Clear();
                txtSrNo.Text = (Convert.ToInt32(strSrNo) + 1).ToString();
                txtMediName.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            if (medicineList.Count == 0)
            {
                MessageBox.Show("Enter Some Products", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgvMediList.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow row in dgvMediList.Rows)
                    {
                        SqlCommand cmdSelect = new SqlCommand("Select MedicineName, Quantity from MedicineStock where MedicineName = '" + row.Cells[1].Value +"'", conConnection);
                        SqlDataReader reader = cmdSelect.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader["MedicineName"].ToString() == row.Cells[1].Value.ToString())
                            {
                                int quantity = Convert.ToInt32(reader["Quantity"].ToString()) + Convert.ToInt32(row.Cells[3].Value);
                                SqlCommand smdUpdate = new SqlCommand("update MedicineStock set Quantity = '"+ quantity +"' where MedicineName = '"+ row.Cells[1].Value +"'", conConnection);
                                reader.Close();

                                smdUpdate.ExecuteNonQuery();
                            }
                        reader.Close();
                        }
                        else
                        {
                            reader.Close();
                        SqlCommand cmdInsert = new SqlCommand("Insert into MedicineStock (MedicineName, BatchName, Quantity, Rate) values ('" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "')", conConnection);

                        cmdInsert.ExecuteNonQuery();

                        }
                        
                    }
                }
                MessageBox.Show("Record is Saved.", "Aknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvMediList.DataSource = null;
            medicineList.Clear();
            txtSrNo.Text = "1";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            txtSrNo.Text = "1";
            medicineList.Clear();
            dgvMediList.DataSource = null;

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only integer value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
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

        private void txtMediName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatch.Focus();
            }
        }

        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRate.Focus();
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void dgvMediList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvMediList.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvMediList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvMediList.Columns["SrNo"].Visible = false;

        }

        private void txtMediName_TextChanged(object sender, EventArgs e)
        {
            if (txtMediName.Text != "")
            {
                btnCancel.Enabled = true;
            }
            else
            {
                btnCancel.Enabled = false;
            }
        }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {
            if (txtBatch.Text != "")
            {
                btnCancel.Enabled = true;
            }
            else {
                    btnCancel.Enabled = false;
                    }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != "")
            {
                btnCancel.Enabled = true;
            }
            else {
                        btnCancel.Enabled = false;
                        }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text != "")
            {
                btnCancel.Enabled = true;
            }
            else {
                            btnCancel.Enabled = false;
                            }
        }
    }
}
