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
    public partial class SupplyInvoice : Form
    {
        public SupplyInvoice()
        {
            InitializeComponent();
        }
        SqlConnection objConnection1;
        SqlCommand cmdSelectAmount;
        SqlCommand cmdInsertCustomer;
        SqlCommand cmdInsertInvoice;
        SqlCommand cmdInsertAmount;
        SqlCommand cmdSelectCmd;
        SqlDataAdapter daInvoice;
        DataSet dsInvoice;
        

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
        public void ClearRichTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            txtCustomerName.Focus();
            txtSerialNo.Text = "1";
            txtTotalPrice.Text = "0";
            txtTotalAmount.Text = "0";
            txtAdvance.Text = "0";
            txtbalance.Text = "0";
            objConnection1 = new SqlConnection(SystemFunctions.ConnectionString());

            objConnection1.Open();
            try
            {
                SqlCommand MaxInvoice = new SqlCommand("Select max(InvoiceNo) From Customer", objConnection1);
                SqlDataReader MaxReader = MaxInvoice.ExecuteReader();
                if (MaxReader.Read())
                {
                    double max = Convert.ToDouble(MaxReader.GetValue(0));
                    max++;
                    var Num = Convert.ToInt32(max);
                    txtInvoice.Text = Num.ToString().PadLeft(5, '0');
                }



                MaxReader.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConnection1.Close();

            }



            //gridProducts.DataSource = GetDataFromLogin(); test column

        }

        //private DataTable GetDataFromLogin()
        //{
        //    DataTable dtlogin = new DataTable();
        //    string varSelect = "SELECT User_name FROM Login";
        //    objSelectCmd = new SqlCommand(varSelect, objConnection1);
        //    objConnection1.Open();
        //    SqlDataReader objReader = objSelectCmd.ExecuteReader();
        //    dtlogin.Load(objReader);
        //    return dtlogin;
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = Convert.ToString(DateTime.Now);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            ClearTextBoxes();
            ClearRichTextBoxes();
            txtCustomerName.Focus();
            txtSerialNo.Text = "1";
            txtTotalPrice.Text = "0";
            txtAdvance.Text = "0";
            txtbalance.Text = "0";
            if (dsInvoice != null)
            {
                dsInvoice.Clear();
            }
            else
            {
                MessageBox.Show("DataSet is Clear.", "Message", MessageBoxButtons.OK);
            }
            //objConnection1.Close();
            objConnection1.Open();
            try
            {
                SqlCommand MaxInvoice = new SqlCommand("Select max(InvoiceNo) From Customer", objConnection1);
                SqlDataReader MaxReader = MaxInvoice.ExecuteReader();
                if (MaxReader.Read())
                {
                    double max = Convert.ToDouble(MaxReader.GetValue(0));
                    max++;
                    var Num = Convert.ToInt32(max);
                    txtInvoice.Text = Num.ToString().PadLeft(5, '0');
                }

                MaxReader.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConnection1.Close();
            }

        }


        private void richTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as RichTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as RichTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


        public string TotalPrice(string varQuantity, string varUnitPrice)
        {
            double varNewQuantity = Convert.ToDouble(varQuantity);
            double varNewUnitPrice = Convert.ToDouble(varUnitPrice);
            double varTotalPrice = varNewQuantity * varNewUnitPrice;
            string varTotalpriceS = Convert.ToString(varTotalPrice);
            return varTotalpriceS;
        }
        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            };
            //if (e.KeyChar == '.'
            //    && (sender as RichTextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
        }



        private void txtSerialNo_TextChanged(object sender, EventArgs e)
        {
            txtSerialNo.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.SelectionAlignment = HorizontalAlignment.Center;
            if (txtQuantity.Text != "" && txtUnitPrice.Text != "")
            {
                txtTotalPrice.Text = TotalPrice(txtQuantity.Text, txtUnitPrice.Text);
            }

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            txtUnitPrice.SelectionAlignment = HorizontalAlignment.Center;
            if (txtQuantity.Text != "" && txtUnitPrice.Text != "")
            {
                txtTotalPrice.Text = TotalPrice(txtQuantity.Text, txtUnitPrice.Text);
            }


        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            txtTotalPrice.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void txtxBatchNo_TextChanged(object sender, EventArgs e)
        {
            txtxBatchNo.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as RichTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as RichTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as RichTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as RichTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                
                if (txtCustomerName.Text == "" && txtAddress.Text == "" && txtProduct.Text == "" && txtQuantity.Text == "" && txtxBatchNo.Text == "" && txtUnitPrice.Text == "")
                {
                    MessageBox.Show("All Fields are Required.","Message",MessageBoxButtons.OK);
                    txtCustomerName.Focus();
                }
                else if(txtCustomerName.Text == "")
                {
                    MessageBox.Show("Customer Name is Required.", "Message", MessageBoxButtons.OK);
                    txtCustomerName.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Customer Address is Required.", "Message", MessageBoxButtons.OK);
                    txtAddress.Focus();
                }
                else if (txtProduct.Text == "")
                {
                    MessageBox.Show("Product Name is Required.", "Message", MessageBoxButtons.OK);
                    txtProduct.Focus();
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Quantity is Required.", "Message", MessageBoxButtons.OK);
                    txtQuantity.Focus();
                }
                else if (txtxBatchNo.Text == "")
                {
                    MessageBox.Show("Batch No. is Required.", "Message", MessageBoxButtons.OK);
                    txtxBatchNo.Focus();
                }
                else if (txtUnitPrice.Text == "")
                {
                    MessageBox.Show("Unit Price is Required.", "Message", MessageBoxButtons.OK);
                    txtUnitPrice.Focus();
                }
                
                else
                {
                    //objConnection1.Close();
                    objConnection1.Open();
                    try
                    {
                        cmdInsertInvoice = new SqlCommand("INSERT INTO SupplyInvoice ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice],[TotalPrice]) VALUES ('" + txtInvoice.Text + "' , '" + txtSerialNo.Text + "','" + txtProduct.Text + "','" + txtQuantity.Text + "','" + txtxBatchNo.Text + "','" + txtUnitPrice.Text + "','" + txtTotalPrice.Text + "')", objConnection1);
                        cmdInsertInvoice.ExecuteNonQuery();
                        cmdSelectCmd = new SqlCommand("SELECT SerialNo, Product, Quantity, BatchNo, UnitPrice, TotalPrice FROM SupplyInvoice WHERE InvoiceNo == '" + txtInvoice.Text + "'", objConnection1);
                        #region FILL GRIDVIEW
                        daInvoice = new SqlDataAdapter(cmdSelectCmd.CommandText, objConnection1);

                        dsInvoice = new DataSet();

                        daInvoice.Fill(dsInvoice, "Invoice");
                        gridSupplyInvoice.DataSource = dsInvoice.Tables["Invoice"].DefaultView;
                        #endregion

                        

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        objConnection1.Close();

                    }


                    txtProduct.Clear(); txtQuantity.Clear(); txtxBatchNo.Clear(); txtUnitPrice.Clear(); txtTotalPrice.Clear();
                    txtSerialNo.Text = Convert.ToString(Convert.ToInt32(txtSerialNo.Text) + 1);
                    txtProduct.Focus();
                    txtTotalProducts.Text = Convert.ToString(Convert.ToInt32(txtSerialNo.Text) - 1);
                    txtTotalPrice.Text = "0";
                    //objConnection1.Close();
                }
                
                
            }
        }


        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //objConnection1.Close();

            //objConnection1.Open();
            if (txtCustomerName.Text == "" &&  txtAddress.Text == "" && txtTotalAmount.Text == "0")
            {
                MessageBox.Show("All Fields are Required.","Message",MessageBoxButtons.OK);
                txtCustomerName.Focus();
            }
            else if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Customer Name Required.", "Message", MessageBoxButtons.OK);
                txtCustomerName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Custommer Address Required.", "Message", MessageBoxButtons.OK);
                txtAddress.Focus();
            }
            else if (txtTotalAmount.Text == "0")
            {
                MessageBox.Show("Total Amount is Zero.", "Message", MessageBoxButtons.OK);
            }
            else
            {
                objConnection1.Open();
                try
                {
                    cmdInsertCustomer = new SqlCommand("INSERT INTO Customer ([InvoiceNo], [CustomerName], [Address]) VALUES ('" + txtInvoice.Text + "', '" + txtCustomerName.Text + "','" + txtAddress.Text + "')", objConnection1);
                    cmdInsertCustomer.ExecuteNonQuery();
                    cmdInsertAmount = new SqlCommand("INSERT INTO Amount ([InvoiceNo], [TotalAmount]) VALUES ('" + txtInvoice.Text + "','" + txtTotalAmount.Text + "')", objConnection1);
                    cmdInsertAmount.ExecuteNonQuery();
                    MessageBox.Show("Record is Entered.", "Message", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    objConnection1.Close();
                }
            }
            
            //objConnection1.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            previewSupplyInvoice.Document = printSupplyInvoice;
            previewSupplyInvoice.ShowDialog();
            //printSupplyInvoice.Print();

        }

        private void printSupplyInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bm = new Bitmap(this.gridSupplyInvoice.Width, this.gridSupplyInvoice.Height);
            //gridSupplyInvoice.DrawToBitmap(bm, new Rectangle(0, 0, this.gridSupplyInvoice.Width, this.gridSupplyInvoice.Height));
            //e.Graphics.DrawImage(bm, 20, 280);

            #region Logo
            Bitmap bmLogo = Properties.Resources.zmc;
            Image zmc = bmLogo;
            e.Graphics.DrawImage(zmc, 22, 10);
            #endregion

            #region customer Info
            e.Graphics.DrawString("No. " + txtInvoice.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(650, 110));
            e.Graphics.DrawString("Date And Time: " + lblDateTime.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(22, 110));
            e.Graphics.DrawString(lblCustomerName.Text + " " + txtCustomerName.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(22, 145));
            e.Graphics.DrawString(lblAddress.Text + " " + txtAddress.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(22, 180));
            #endregion

            #region horizontal
            Bitmap bmhorline = Properties.Resources.line;
            Image line = bmhorline;

            #region invoice
            Bitmap bmInvoiceLine = Properties.Resources.invoice_line;
            Image Invoice = bmInvoiceLine;
            e.Graphics.DrawImage(Invoice, 690, 140);
            #endregion

            #region name
            Bitmap bmName = Properties.Resources.line2;
            Image imgName = bmName;
            e.Graphics.DrawImage(imgName, 222, 175);

            #endregion address

            #region address
            Bitmap bmAddress = Properties.Resources.line3;
            Image imgAddress = bmAddress;
            e.Graphics.DrawImage(imgAddress, 128, 210);
            #endregion

            #region horizontal1
            e.Graphics.DrawImage(line, 20, 230);
            #endregion

            #region Horizontal2
            int rowpositionline = 270;
            for(int i = 0; i <= 16; i++)
            {
                e.Graphics.DrawImage(line, 20, rowpositionline);
                rowpositionline += 40;
            }
            
            e.Graphics.DrawImage(line, 20, 982);
            #endregion
            #endregion

            #region Item Headings
            e.Graphics.DrawString(lblSerialNo.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(21, 235));
            e.Graphics.DrawString(lblProduct.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(85, 235));
            e.Graphics.DrawString(lblQuantity.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(462, 235));
            e.Graphics.DrawString("Batch", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(530, 235));
            e.Graphics.DrawString("Rate", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(632, 235));
            e.Graphics.DrawString("Total", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(710, 235));
            #endregion
            
            #region vertical lines
            Bitmap bmline = Properties.Resources.verticle_line;
            Image verline = bmline;
            Bitmap bmline6 = Properties.Resources.line6;
            Image verline6 = bmline6;
            Bitmap bmline8 = Properties.Resources.line8;
            Image verline8 = bmline8;
            e.Graphics.DrawImage(verline, 20, 234);
            e.Graphics.DrawImage(verline, 74, 234);
            e.Graphics.DrawImage(verline, 462, 234);
            e.Graphics.DrawImage(verline8, 520, 234);
            e.Graphics.DrawImage(verline8, 627, 234);
            e.Graphics.DrawImage(verline8, 705, 234);
            e.Graphics.DrawImage(verline, 823, 234);
            
            #endregion

            #region Items
            //int columnPosition = 30;
            int rowPosition = 278;
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("SupplyInvoice");
            dt.Columns.Add("Sr.#", Type.GetType("System.String"));
            dt.Columns.Add("Product", Type.GetType("System.String"));
            dt.Columns.Add("Quantity", Type.GetType("System.String"));
            dt.Columns.Add("Batch", Type.GetType("System.String"));
            dt.Columns.Add("Rate", Type.GetType("System.String"));
            dt.Columns.Add("TotalPrice", Type.GetType("System.String"));

            DataRow row;

            string varSerial = string.Empty;
            string varProduct = string.Empty;
            string varQnty = string.Empty;
            string varBatch = string.Empty;
            string varRate = string.Empty;
            string varTotalPrice = string.Empty;

            for (int i = 0; i < gridSupplyInvoice.RowCount; i++)
            {
                varSerial =     gridSupplyInvoice.Rows[i].Cells[0].Value.ToString();
                varProduct =    gridSupplyInvoice.Rows[i].Cells[1].Value.ToString();
                varQnty =       gridSupplyInvoice.Rows[i].Cells[2].Value.ToString();
                varBatch =      gridSupplyInvoice.Rows[i].Cells[3].Value.ToString();
                varRate =       gridSupplyInvoice.Rows[i].Cells[4].Value.ToString();
                varTotalPrice = gridSupplyInvoice.Rows[i].Cells[5].Value.ToString();

                row = dt.NewRow();
                row["Sr.#"] = varSerial;
                row["Product"] = varProduct;
                row["Quantity"] = varQnty;
                row["Batch"] = varBatch;
                row["Rate"] = varRate;
                row["TotalPrice"] = varTotalPrice;

                dt.Rows.Add(row);

                e.Graphics.DrawString(row["Sr.#"].ToString(), new Font("Calibri", 15, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(38, rowPosition));
                e.Graphics.DrawString(row["Product"].ToString(), new Font("Calibri", 15, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(75, rowPosition));
                e.Graphics.DrawString(row["Quantity"].ToString(), new Font("Calibri", 15, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(470, rowPosition));
                e.Graphics.DrawString(row["Batch"].ToString(), new Font("Calibri", 15, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(525, rowPosition));
                e.Graphics.DrawString(row["Rate"].ToString(), new Font("Calibri", 15, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(637, rowPosition));
                e.Graphics.DrawString(row["TotalPrice"].ToString() + "/-Rs", new Font("Calibri", 15, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(710, rowPosition));

                rowPosition += 40;
            }
            e.Graphics.DrawString("Advance", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(85, 835));
            e.Graphics.DrawString(txtAdvance.Text + "/- Rs", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(550, 835));
            e.Graphics.DrawString("Balance", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(85, 875));
            e.Graphics.DrawString(txtbalance.Text + "/- Rs", new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(550, 875));

            e.Graphics.DrawString("Total Amount", new Font("Calibri", 25, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(85, 930));
            e.Graphics.DrawString(txtTotalAmount.Text + "/-Rs", new Font("Calibri", 25, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(550, 930));


            #endregion

            #region Warranty
            Bitmap bmWarranty = Properties.Resources.wrranty;
            Image Warranty = bmWarranty;
            e.Graphics.DrawImage(Warranty, 22, 990);

            #endregion
            
        }



        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            //objConnection1.Close();

            objConnection1.Open();
            try
            {
                if (txtInvoice.Text != "")
                {
                    cmdSelectAmount = new SqlCommand("SELECT SUM(TotalPrice) FROM SupplyInvoice WHERE InvoiceNo == '" + txtInvoice.Text + "'", objConnection1);
                    double amount = Convert.ToDouble(cmdSelectAmount.ExecuteScalar());
                    txtTotalAmount.Text = amount.ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConnection1.Close();

            }

        }

        private void previewSupplyInvoice_Load(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridSupplyInvoice_Scroll(object sender, ScrollEventArgs e)
        {
            //if (gridSupplyInvoice.Rows.Count > 0)
            //{
            //    gridSupplyInvoice.FirstDisplayedScrollingRowIndex = gridSupplyInvoice.RowCount - 1;


            //}
            //else
            //{
            //    gridSupplyInvoice.ScrollBars = ScrollBars.None;
            //}
        }

        private void lblAdvance_Click(object sender, EventArgs e)
        {

        }

        private void txtAdvance_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtAdvance.Text == "0")
            {
                txtAdvance.Text = "";
            }
        }

        private void txtbalance_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtbalance.Text == "0")
            {
                txtbalance.Text = "";
            }
        }

        

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}