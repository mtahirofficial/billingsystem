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

namespace Billing_System.User_Controls
{
    public partial class ViewStock : UserControl
    {
        private static ViewStock _instance;
        public static ViewStock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ViewStock();
                }
                return _instance;
            }
        }
        public ViewStock()
        {
            InitializeComponent();
        }

        SqlConnection con;

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

        private void ViewStock_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(SystemFunctions.ConnectionString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (txtMediName.Text.Trim() == "")
            {
                MessageBox.Show("Enter Medicine Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMediName.Focus();
            } else
            {
                SqlCommand cmdSelect = new SqlCommand("select * from MedicineStock where MedicineName = '"+ txtMediName.Text +"'", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, con);
                DataSet dataSet = new DataSet();
                SqlDataReader reader = cmdSelect.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    dataAdapter.Fill(dataSet, "mediList");
                    dgvMediList.DataSource = dataSet.Tables["mediList"].DefaultView;
                }
                else
                {
                    MessageBox.Show("Medicine doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMediName.Focus();
                }
                    reader.Close();
            }

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
            SqlCommand cmdSelect = new SqlCommand("select * from MedicineStock", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, con);
            DataSet dataSet = new DataSet();
            SqlDataReader reader = cmdSelect.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                dataAdapter.Fill(dataSet, "mediList");
                dgvMediList.DataSource = dataSet.Tables["mediList"].DefaultView;
            }
            else
            {
                MessageBox.Show("There is no stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMediList.DataSource = null;
                txtMediName.Focus();
            }
            reader.Close();
            
        }

        private void dgvMediList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvMediList.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvMediList.CurrentCell.RowIndex;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmdDelete = new SqlCommand("delete from MedicineStock where ID = '" + dgvMediList.Rows[rowIndex].Cells[0].Value + "'", con);
            SqlDataReader delReader = cmdDelete.ExecuteReader();
            delReader.Close();

            SqlCommand cmdSelect = new SqlCommand("select * from MedicineStock", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, con);
            DataSet dataSet = new DataSet();
            SqlDataReader reader = cmdSelect.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                dataAdapter.Fill(dataSet, "mediList");
                dgvMediList.DataSource = dataSet.Tables["mediList"].DefaultView;
            }
            else
            {
                MessageBox.Show("There is no stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMediList.DataSource = null;
                txtMediName.Focus();
            }
            reader.Close();
        }

        private void dgvMediList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvMediList.Rows.Count > 0)
                {
                    var ht = dgvMediList.HitTest(e.X, e.Y);
                    dgvMediList.ClearSelection();
                    dgvMediList.Rows[ht.RowIndex].Selected = true;
                    menuDGV.Show(dgvMediList, e.X, e.Y);
                }
                
            }
        }

        private void dgvMediList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteToolStripMenuItem.PerformClick();
            }
        }
        static string oldQuantity;
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int rowIndex = dgvMediList.CurrentCell.RowIndex;
            btnUpdate.Enabled = true;
            int rowIndex = dgvMediList.SelectedRows[0].Index;
            txtID.Text = dgvMediList.Rows[rowIndex].Cells[0].Value.ToString();
            txtMedi.Text = dgvMediList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBatch.Text = dgvMediList.Rows[rowIndex].Cells[2].Value.ToString();
            txtQty.Text = oldQuantity = dgvMediList.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvMediList.Rows[rowIndex].Cells[4].Value.ToString();
            dgvMediList.ClearSelection();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmdUpdate = new SqlCommand("UPDATE MedicineStock SET MedicineName = '" + txtMedi.Text.Trim() +"', BatchName = '" + txtBatch.Text.Trim() + "', Quantity = '" + txtQty.Text.Trim()  + "', Rate = '" + txtRate.Text.Trim()  + "' where ID = '" + txtID.Text.Trim() + "'", con);
            cmdUpdate.ExecuteNonQuery();
            SqlCommand cmdSelect = new SqlCommand("select * from MedicineStock", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSelect.CommandText, con);
            DataSet dataSet = new DataSet();
            SqlDataReader reader = cmdSelect.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                dataAdapter.Fill(dataSet, "mediList");
                dgvMediList.DataSource = dataSet.Tables["mediList"].DefaultView;
            }
            else
            {
                MessageBox.Show("There is no stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMediList.DataSource = null;
                txtMediName.Focus();
            }
            btnUpdate.Enabled = false;
            reader.Close();
            ClearTextBoxes();
        }
    }
}
