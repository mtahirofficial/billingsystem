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
using System.Drawing.Printing;
using System.IO;

namespace Billing_System.User_Controls
{
    public partial class ShopInvoice : UserControl
    {
        private static ShopInvoice _instance;
        public static ShopInvoice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ShopInvoice();
                }
                return _instance;
            }
        }

        public ShopInvoice()
        {
            InitializeComponent();
            AutoCompleteCombo();
        }
        public List<MedicineItems> medicineList = new List<MedicineItems>();
        SqlConnection conConnection;

        string strSupplier;

        //DataSet dsInvoice;
        //private double sum;
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

        public void FillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            SqlCommand command = new SqlCommand(query, conConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
public static string maxNumber;
        public void MaxInvoice()
        {
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            SqlCommand MaxInvoice = new SqlCommand("Select max(InvoiceNo) as maxInvoiceNo From ShopAmount", conConnection);
            SqlDataReader MaxReader = MaxInvoice.ExecuteReader();
            if (MaxReader.Read())
            {
                if (MaxReader.GetValue(0).ToString() == "")
                {
                    maxNumber = "00001";
                    txtSrNo.Text = "1";

                }
                else
                {
                    double max = Convert.ToDouble(MaxReader.GetValue(0));
                    max++;
                    var Num = Convert.ToInt32(max);
                    maxNumber = Num.ToString().PadLeft(5, '0');
                    txtSrNo.Text = "1";

                }
            }
            MaxReader.Close();
            conConnection.Close();
            txtInvoice.Text = maxNumber;
            //return maxNumber;
        }

        public void getValues()
        {
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            string query = "select ID, MedicineName from MedicineStock";
            FillCombo(cbMediName, query, "MedicineName", "ID");
            cbMediName_SelectedIndexChanged(null, null);
            conConnection.Close();
        }

        void AutoCompleteCombo()
        {
            conConnection = new SqlConnection(SystemFunctions.ConnectionString());

            conConnection.Open();

            cbMediName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMediName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            SqlCommand cmdSupplier = new SqlCommand("Select MedicineName from MedicineStock", conConnection);
            SqlDataReader reader = cmdSupplier.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    strSupplier = reader["MedicineName"].ToString();
                    coll.Add(strSupplier);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Close();
            cbMediName.AutoCompleteCustomSource = coll;
            conConnection.Close();
        }

        public string TotalPrice(string varQuantity, string varUnitPrice)
        {
            double varNewQuantity = Convert.ToDouble(varQuantity);
            double varNewUnitPrice = Convert.ToDouble(varUnitPrice);
            double varTotalPrice = varNewQuantity * varNewUnitPrice;
            string varTotalpriceS = Convert.ToString(varTotalPrice);
            return varTotalpriceS;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != "" && txtRate.Text != "")
            {
                txtPrice.Text = TotalPrice(txtQty.Text, txtRate.Text);
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != "" && txtRate.Text != "")
            {
                txtPrice.Text = TotalPrice(txtQty.Text, txtRate.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = Convert.ToString(DateTime.Now);

        }

        private void ShopInvoice_Load(object sender, EventArgs e)
        {
            conConnection = new SqlConnection(SystemFunctions.ConnectionString());
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            try
            {
                MaxInvoice();
                //txtInvoice.Text = MaxInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            try
            {
                //string query = "select ID, MedicineName from MedicineStock";
                //FillCombo(cbMediName, query, "MedicineName", "ID");
                //cbMediName_SelectedIndexChanged(null, null);
                getValues();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conConnection.Close();

            }
        }

        private void txtSrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            if (txtName.Text.Trim() == "" && txtPhone.Text.Trim() == "" && lblTotalBill.Text.Trim() == "0")
            {
                MessageBox.Show("All Fields are Required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name is Required.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Customer Phone No. is Required.", "Phone Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else if (lblTotalBill.Text.Trim() == "0")
            {
                MessageBox.Show("Total Amount is Zero.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (dgvMediList.Rows.Count >= 1)
                    {
                        foreach (DataGridViewRow row in dgvMediList.Rows)
                        {


                            SqlCommand cmdInsert = new SqlCommand("Insert into ShopInvoice (InvoiceNo, SerialNo, Product, BatchNo, Quantity, UnitPrice, TotalPrice, Date) values ('" + txtInvoice.Text + "','" + row.Cells[0].Value + "','" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[4].Value + "','" + row.Cells[5].Value + "','" + row.Cells[6].Value + "','" + row.Cells[7].Value + "')", conConnection);
                            cmdInsert.ExecuteNonQuery();
                            SqlCommand cmdUpdate = new SqlCommand("Update MedicineStock set Quantity = '" + row.Cells[3].Value + "' where MedicineName = '" + row.Cells[1].Value + "'", conConnection);
                            cmdUpdate.ExecuteNonQuery();

                            //MessageBox.Show("0:" + row.Cells[0].Value + "   1:" + row.Cells[1].Value + "   2:" + row.Cells[2].Value + "   3:" + row.Cells[3].Value + "   4:" + row.Cells[4].Value + "   5:" + row.Cells[5].Value + "   6:" + row.Cells[6].Value + "   7:" + row.Cells[7].Value, "Test DatagridView", MessageBoxButtons.OK);
                        }
                    }
                    SqlCommand cmdInsertCustomer = new SqlCommand("INSERT INTO ShopCustomer ([InvoiceNo], [CustomerName], [Mobile]) VALUES ('" + txtInvoice.Text + "', '" + txtName.Text + "','" + txtPhone.Text + "')", conConnection);
                    cmdInsertCustomer.ExecuteNonQuery();
                    SqlCommand cmdInsertAmount = new SqlCommand("INSERT INTO ShopAmount ([InvoiceNo], [TotalAmount]) VALUES ('" + txtInvoice.Text + "','" + lblTotalBill.Text + "')", conConnection);
                    cmdInsertAmount.ExecuteNonQuery();
                    MessageBox.Show("Record is Entered.", "Message", MessageBoxButtons.OK);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    string fileName = (string)(txtPhone.Text);
                    //string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string directory = Application.StartupPath + "//invoices";
                    //string directory = "~/Invoices";


                    printDocument1.PrinterSettings = new PrinterSettings()
                    {
                        // set the printer to 'Microsoft Print to PDF'
                        PrinterName = "Microsoft Print to PDF",

                        // tell the object this document will print to file
                        PrintToFile = true,

                        // set the filename to whatever you like (full path)
                        PrintFileName = Path.Combine(directory, fileName + ".pdf"),
                    };

                    printDocument1.Print();


                    ClearTextBoxes();

                    MaxInvoice();


                    try
                    {
                        string query = "select ID, MedicineName from MedicineStock";
                        FillCombo(cbMediName, query, "MedicineName", "ID");
                        cbMediName_SelectedIndexChanged(null, null);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    txtName.Focus();
                    txtSrNo.Text = "1";
                    txtPrice.Text = "0";
                    txtAdvance.Text = "0";
                    txtBalance.Text = "0";
                    medicineList.Clear();
                    dgvMediList.DataSource = null;
                    lblTotalBill.Text = "0";
                    conConnection.Close();

                }

            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only alphabetics are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        Bitmap bmWarranty;
        Image Warranty;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bmWarranty = Properties.Resources.wrranty_shop;
            Warranty = bmWarranty;
            #region Logo
            Bitmap bmLogo = Properties.Resources.zmc;
            Image zmc = bmLogo;
            e.Graphics.DrawImage(zmc, 22, 10);
            #endregion

            #region customer Info
            e.Graphics.DrawString("No.   " + txtInvoice.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(658, 110));
            e.Graphics.DrawString("Date And Time: " + lblDateTime.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(22, 110));
            e.Graphics.DrawString("Customer Name: " + " " + txtName.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(22, 145));
            e.Graphics.DrawString("Phone No. " + " " + txtPhone.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(22, 180));
            #endregion


            Bitmap bmhorline = Properties.Resources.line;
            Image line = bmhorline;

            #region invoice
            Bitmap bmInvoiceLine = Properties.Resources.invoice_line;
            Image Invoice = bmInvoiceLine;
            //e.Graphics.DrawImage(Invoice, 690, 140);
            e.Graphics.DrawString("------------", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(705, 120));

            #endregion

            #region name
            Bitmap bmName = Properties.Resources.line2;
            Image imgName = bmName;
            //e.Graphics.DrawImage(imgName, 222, 175);
            e.Graphics.DrawString("-----------------------------------------------------------------------", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(222, 155));
            #endregion address
            #region Phone
            Bitmap bmAddress = Properties.Resources.line3;
            Image imgAddress = bmAddress;
            //e.Graphics.DrawImage(imgAddress, 128, 210);
            e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(145, 190));

            #endregion
            #region horizontal1
            e.Graphics.DrawImage(line, 20, 230);

            e.Graphics.DrawImage(line, 20, 265);





            #endregion

            #region Item Headings
            e.Graphics.DrawString(lblSrNo.Text, new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(21, 235));
            //e.Graphics.DrawString(lblMediName.Text, new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(170, 235));
            e.Graphics.DrawString(lblMediName.Text, new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(80, 235));
            e.Graphics.DrawString("Batch #", new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(435, 235));
            e.Graphics.DrawString(lblQty.Text, new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(545, 235));
            e.Graphics.DrawString("Rate", new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(605, 235));
            e.Graphics.DrawString("Total Price", new Font("ArialMT", 18, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(695, 235));
            #endregion

            #region vertical lines
            Bitmap bmline = Properties.Resources.verticle_line;
            Image verline = bmline;
            Bitmap bmline6 = Properties.Resources.line6;
            Image verline6 = bmline6;
            Bitmap bmline8 = Properties.Resources.line8;
            Image verline8 = bmline8;
            //e.Graphics.DrawImage(verline, 20, 234);
            //e.Graphics.DrawImage(verline, 74, 234);
            //e.Graphics.DrawImage(verline, 457, 234);


            //void createVerticleLine( int x, int y)
            //{
            //    int colPos = x;
            //    int rowPos = y;
            //    for (var i = 1; i <= 35; i++)
            //    {
            //        e.Graphics.DrawString("|", new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, colPos, rowPos);
            //        rowPos += 18;

            //    }

            //}
            //createVerticleLine(12, 228);
            //createVerticleLine(67, 228);
            //createVerticleLine(450, 228);
            //createVerticleLine(553, 228);
            //createVerticleLine(618, 228);
            //createVerticleLine(683, 228);
            //createVerticleLine(817, 228);


            #endregion

            #region Items

            int rowPosition = 270;
            for (var i = numberOfItemsPrintedSoFar; i < medicineList.Count; i++)
            {
                numberOfItemsPerPage++;
                if (numberOfItemsPerPage <= 28)
                {
                    numberOfItemsPrintedSoFar++;
                    if (numberOfItemsPrintedSoFar <= medicineList.Count)
                    {
                        e.Graphics.DrawString((medicineList[i].SrNo).ToString(), new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(38, rowPosition));
                        e.Graphics.DrawString(medicineList[i].MedicineName, new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(80, rowPosition));
                        e.Graphics.DrawString(medicineList[i].Batch, new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(440, rowPosition));
                        e.Graphics.DrawString(medicineList[i].Quantity.ToString(), new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(555, rowPosition));
                        e.Graphics.DrawString(medicineList[i].Rate.ToString(), new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(612, rowPosition));
                        e.Graphics.DrawString(medicineList[i].Price.ToString() + "/-Rs", new Font("Calibri", 15, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(700, rowPosition));
                        rowPosition += 25;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                    if (i >= numberOfItemsPrintedSoFar + 1)
                    {
                        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(15, 963));
                        e.Graphics.DrawImage(Warranty, 22, 990);
                    }
                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }

            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(15, 890));

            // Advance
            e.Graphics.DrawString("Advance:", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(85, 910));
            if (txtAdvance.Text != "" && Convert.ToInt32(txtAdvance.Text) >= 0)
            {
                e.Graphics.DrawString(txtAdvance.Text + "/- Rs", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(240, 910));
            }
            else
            {
                e.Graphics.DrawString("0/- Rs", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(240, 910));
            }
            e.Graphics.DrawString("||", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(398, 903));
            e.Graphics.DrawString("||", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(398, 912));

            // Balance
            e.Graphics.DrawString("Balance:", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(450, 910));
            if (txtAdvance.Text != "" && Convert.ToInt32(txtAdvance.Text) >= 0)
            {
                e.Graphics.DrawString(txtBalance.Text + "/- Rs", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(610, 910));
            }
            else
            {
                e.Graphics.DrawString("0/- Rs", new Font("Calibri", 20, FontStyle.Regular), Brushes.DarkSlateBlue, new Point(610, 910));
            }

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(15, 925));

            e.Graphics.DrawString("Total Amount", new Font("Calibri", 25, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(85, 942));
            e.Graphics.DrawString(lblTotalBill.Text + "/-Rs", new Font("Calibri", 25, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(550, 942));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(15, 963));

            #endregion

            #region Warranty
            e.Graphics.DrawImage(Warranty, 22, 990);
            #endregion

            // reset the variables
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void txtAdvance_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAdvance.Text == "0")
            {
                txtAdvance.Text = "";
            }
        }

        private void txtBalance_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBalance.Text == "0")
            {
                txtBalance.Text = "";
            }
        }

        private void txtAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                MessageBox.Show("Only numeric value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                MessageBox.Show("Only numeric value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numeric value is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvMediList.CurrentCell.RowIndex;
            medicineList.RemoveAt(rowIndex);

            dgvMediList.DataSource = null;
            dgvMediList.DataSource = medicineList;

            decimal totalAmount = medicineList.Sum(price => price.Price);
            lblTotalBill.Text = Convert.ToString(totalAmount);
        }

        private void dgvMediList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteToolStripMenuItem.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cbMediName.Text.Trim() == "" && txtQty.Text.Trim() == "" && txtBatch.Text.Trim() == "" && txtRate.Text.Trim() == "")
            {
                MessageBox.Show("All Fields are Required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }

            else if (cbMediName.Text.Trim() == "")
            {
                MessageBox.Show("NMedicine Name is Required.", "Medicine Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMediName.Focus();
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
                    string medicineName = cbMediName.Text.Trim();
                    int index = medicineList.FindIndex(medicineObject => medicineObject.MedicineName == medicineName); // find index of item name in list

                    if (index == -1)    // if index not found
                    {
                        if (Convert.ToInt32(txtQty.Text) > Convert.ToInt32(txtStock.Text)) //if quantity exceeds
                        {
                            MessageBox.Show("Quantity of " + cbMediName.Text.Trim() + " exceeds from stock.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtQty.Focus();
                        }
                        else // if stock exceeds
                        {
                            int remainingStock = Convert.ToInt32(txtStock.Text) - Convert.ToInt32(txtQty.Text);
                            txtRemainingStock.Text = remainingStock.ToString();
                            MedicineItems medicine = new MedicineItems()
                            {
                                SrNo = Convert.ToInt32(txtSrNo.Text),
                                MedicineName = cbMediName.Text,
                                Batch = txtBatch.Text,
                                Stock = remainingStock,
                                Quantity = Convert.ToInt32(txtQty.Text),
                                Rate = Convert.ToDecimal(txtRate.Text),
                                Price = Convert.ToDecimal(txtPrice.Text),
                                Date = DateTime.Now.ToShortDateString()
                            };
                            medicineList.Add(medicine);
                            dgvMediList.DataSource = null;
                            dgvMediList.DataSource = medicineList;

                        }
                    }
                    else // if index found
                    {
                        // check stock
                        txtRemainingStock.Text = medicineList[index].Stock.ToString();
                        if (Convert.ToInt32(txtQty.Text) > Convert.ToInt32(txtRemainingStock.Text)) //if quantity exceeds
                        {
                            MessageBox.Show("Quantity of " + cbMediName.Text.Trim() + " exceeds from stock.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtQty.Focus();
                        }
                        else // if stock exceeds
                        {
                            txtRemainingStock.Text = Convert.ToString(Convert.ToInt32(txtRemainingStock.Text) - Convert.ToInt32(txtQty.Text));
                            medicineList[index].Quantity += Convert.ToInt32(txtQty.Text);
                            medicineList[index].Stock = Convert.ToInt32(txtRemainingStock.Text);
                            dgvMediList.DataSource = null;
                            dgvMediList.DataSource = medicineList;
                        }
                    }

                    //dgvMediList.Rows.Add(null, txtSrNo.Text, cbMediName.Text, txtBatch.Text, txtQty.Text, txtRate.Text, txtPrice.Text, DateTime.Now.ToShortDateString());
                    //foreach (DataGridViewRow row in dgvMediList.Rows)
                    //{
                    //    sum += Convert.ToDouble(row.Cells[5].Value);
                    //}
                    decimal totalAmount = medicineList.Sum(price => price.Price);
                    lblTotalBill.Text = Convert.ToString(totalAmount);
                    //SqlCommand cmdSelectAmount = new SqlCommand("SELECT SUM(TotalPrice) as total FROM ShopInvoice WHERE InvoiceNo = '" + txtInvoice.Text + "'", conConnection);
                    //double amount = Convert.ToDouble(cmdSelectAmount.ExecuteScalar());
                    //lblTotalBill.Text = amount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string strSrNo = txtSrNo.Text;
                //cbMediName.SelectedIndex = 0;
                txtQty.Clear();
                txtSrNo.Text = Convert.ToString(Convert.ToInt32(strSrNo) + 1);
                cbMediName.Focus();
                txtItems.Text = strSrNo;
                txtPrice.Text = "0";
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void cbMediName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void cbMediName_Leave(object sender, EventArgs e)
        {


        }

        private void cbMediName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            string medicineName = cbMediName.Text.Trim();
            int index = medicineList.FindIndex(medicineObject => medicineObject.MedicineName == medicineName); // find index of item name in list

            int val;
            Int32.TryParse(cbMediName.SelectedValue.ToString(), out val);
            string query = "select ID, MedicineName, BatchName, Quantity, Rate from MedicineStock where ID = '" + val + "'";
            SqlCommand cmdSelect = new SqlCommand(query, conConnection);

            SqlDataReader reader = cmdSelect.ExecuteReader();

            if (reader.Read())
            {
                txtBatch.Text = reader["BatchName"].ToString();
                txtStock.Text = reader["Quantity"].ToString();
                if (index == -1)
                {
                    txtRemainingStock.Text = reader["Quantity"].ToString();
                }
                else
                {
                    txtRemainingStock.Text = medicineList[index].Stock.ToString();
                }
                txtRate.Text = reader["Rate"].ToString();

                //if (Convert.ToInt32(txtStock.Text) <= 5)
                //{
                //    MessageBox.Show("Stock is least", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            reader.Close();
            conConnection.Close();

        }

        private void cbMediName_Leave_1(object sender, EventArgs e)
        {
            if (conConnection.State == ConnectionState.Closed)
            {
                conConnection.Open();
            }
            //int val;
            //Int32.TryParse(cbMediName.SelectedValue.ToString(), out val);
            string query = "select ID, MedicineName, BatchName, Quantity, Rate from MedicineStock where MedicineName = '" + cbMediName.Text.Trim() + "'";
            SqlCommand cmdSelect = new SqlCommand(query, conConnection);

            SqlDataReader reader = cmdSelect.ExecuteReader();

            if (reader.Read())
            {
                txtBatch.Text = reader["BatchName"].ToString();
                //txtQty.Text = reader["Quantity"].ToString();
                txtRate.Text = reader["Rate"].ToString();
            }
            reader.Close();
            conConnection.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" || txtPhone.Text.Trim() != "" || lblTotalBill.Text.Trim() != "0" || medicineList.Count > 0 || txtQty.Text.Trim() != "")
            {
                if (conConnection.State == ConnectionState.Closed)
                {
                    conConnection.Open();
                }
                DialogResult result = MessageBox.Show("Are you sure, you want to cancel ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    ClearTextBoxes();
                    SqlCommand MaxInvoice = new SqlCommand("Select max(InvoiceNo) as maxInvoiceNo From ShopCustomer", conConnection);
                    SqlDataReader MaxReader = MaxInvoice.ExecuteReader();
                    if (MaxReader.Read())
                    {
                        if (MaxReader.GetValue(0).ToString() == "")
                        {
                            txtInvoice.Text = "00001";
                        }
                        else
                        {

                            double max = Convert.ToDouble(MaxReader.GetValue(0));
                            max++;
                            var Num = Convert.ToInt32(max);
                            txtInvoice.Text = Num.ToString().PadLeft(5, '0');
                        }
                        MaxReader.Close();
                    }
                    try
                    {
                        string query = "select ID, MedicineName from MedicineStock";
                        FillCombo(cbMediName, query, "MedicineName", "ID");
                        cbMediName_SelectedIndexChanged(null, null);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    txtName.Focus();
                    txtSrNo.Text = "1";
                    txtPrice.Text = "0";
                    txtAdvance.Text = "0";
                    txtBalance.Text = "0";
                    medicineList.Clear();
                    dgvMediList.DataSource = null;
                    lblTotalBill.Text = "0";
                }
                else
                {

                    //int val;
                    //Int32.TryParse(cbMediName.SelectedValue.ToString(), out val);
                    string query1 = "select ID, MedicineName, BatchName, Quantity, Rate from MedicineStock where MedicineName = '" + cbMediName.Text.Trim() + "'";
                    SqlCommand cmdSelect = new SqlCommand(query1, conConnection);

                    SqlDataReader reader = cmdSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        txtBatch.Text = reader["BatchName"].ToString();
                        //txtQty.Text = reader["Quantity"].ToString();
                        txtRate.Text = reader["Rate"].ToString();
                    }
                    reader.Close();

                    try
                    {
                        string query = "select ID, MedicineName from MedicineStock";
                        FillCombo(cbMediName, query, "MedicineName", "ID");
                        cbMediName_SelectedIndexChanged(null, null);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conConnection.Close();
                }
            }
        }

        private void dgvMediList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvMediList.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvMediList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cellIndex = dgvMediList.CurrentCell.ColumnIndex;
            int rowIndex = dgvMediList.CurrentCell.RowIndex;
            string currentCell = dgvMediList.CurrentCell.Value.ToString();
            string beforeCurrentCell = dgvMediList.Rows[rowIndex].Cells[cellIndex - 1].Value.ToString();
            string afterCurrentCell = dgvMediList.Rows[rowIndex].Cells[cellIndex + 1].Value.ToString();
            string colName = dgvMediList.CurrentCell.OwningColumn.Name;

            if (colName == "Quantity")
            {
                dgvMediList.Rows[rowIndex].Cells[cellIndex + 2].Value = Convert.ToString(Convert.ToInt32(currentCell) * Convert.ToInt32(afterCurrentCell));
            }
            else if (colName == "Rate")
            {
                dgvMediList.Rows[rowIndex].Cells[cellIndex + 1].Value = Convert.ToString(Convert.ToInt32(currentCell) * Convert.ToInt32(beforeCurrentCell));
            }


        }

        private void dgvMediList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvMediList.Columns["SrNo"].Visible = false;
            this.dgvMediList.Columns["Date"].Visible = false;
            this.dgvMediList.Columns["Stock"].Visible = false;

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            //this.

            if (txtStock.Text != "")
            {
                if (Convert.ToInt32(txtStock.Text) <= 5)
                {
                    MessageBox.Show("Stock is least", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

}