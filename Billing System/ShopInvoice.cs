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
    public partial class ShopInvoice : Form
    {
        public ShopInvoice()
        {
            InitializeComponent();
        }
        SqlConnection objConnection;
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
        public string TotalPrice(string varQuantity, string varUnitPrice)
        {
            double varNewQuantity = Convert.ToDouble(varQuantity);
            double varNewUnitPrice = Convert.ToDouble(varUnitPrice);
            double varTotalPrice = varNewQuantity * varNewUnitPrice;
            string varTotalpriceS = Convert.ToString(varTotalPrice);
            return varTotalpriceS;
        }
        private string TotalAmount(string text1, string text2)
        {
            double varNewTotalprice = Convert.ToDouble(text1);
            double varNewTotalAmount = Convert.ToDouble(text2);
            string varTotalAmount = Convert.ToString(varNewTotalprice + varNewTotalAmount);
            //string varTotalpriceS = Convert.ToString(varTotalAmount);
            return varTotalAmount;

            //return MessageBox.Show("TotalAmount","Message",MessageBoxButtons.OK);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearRichTextBoxes();
            ClearTextBoxes();
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
            
            objConnection.Open();
            try
            {
                SqlCommand MaxInvoice = new SqlCommand("Select max(InvoiceNo) From ShopCustomer", objConnection);
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
                objConnection.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
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

        private void txtxBatchNo_TextChanged(object sender, EventArgs e)
        {
            txtxBatchNo.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            txtTotalPrice.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = Convert.ToString(DateTime.Now);

        }

        private void ShopInvoice_Load(object sender, EventArgs e)
        {
            txtSerialNo.Text = "1";
            txtTotalPrice.Text = "0";
            txtTotalAmount.Text = "0";
            txtAdvance.Text = "0";
            txtbalance.Text = "0";
            txtCustomerName.Focus();
            objConnection = new SqlConnection(SystemFunctions.ConnectionString());
            objConnection.Open();
            try
            {
                SqlCommand MaxInvoice = new SqlCommand("Select max(InvoiceNo) From ShopCustomer", objConnection);
                SqlDataReader MaxReader = MaxInvoice.ExecuteReader();
                if (MaxReader.Read())
                {
                    double max = Convert.ToDouble(MaxReader.GetValue(0));
                    //txtInvoice.Text = Convert.ToString(max + 1);
                    max++;
                    var Num = Convert.ToInt32(max);
                    txtInvoice.Text = Num.ToString().PadLeft(5, '0');
                }


                MaxReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                objConnection.Close();

            }
        }

        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //if (e.KeyChar == '.'
            //    && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
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

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtTotalProducts_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtCustomerName.Text == "" && txtPhone.Text == "" && txtProduct.Text == "" && txtQuantity.Text == "" && txtxBatchNo.Text == "" && txtUnitPrice.Text == "")
                {
                    MessageBox.Show("All Fields are Required.", "Message", MessageBoxButtons.OK);
                    txtCustomerName.Focus();
                }
                else if (txtCustomerName.Text == "")
                {
                    MessageBox.Show("Customer Name is Required.", "Message", MessageBoxButtons.OK);
                    txtCustomerName.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Customer Phone No. is Required.", "Message", MessageBoxButtons.OK);
                    txtPhone.Focus();
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
                    objConnection.Open();
                    try
                    {
                        SqlCommand cmdInsertInvoice = new SqlCommand("INSERT INTO ShopInvoice ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice],[TotalPrice]) VALUES ('" + txtInvoice.Text + "' , '" + txtSerialNo.Text + "','" + txtProduct.Text + "','" + txtQuantity.Text + "','" + txtxBatchNo.Text + "','" + txtUnitPrice.Text + "','" + txtTotalPrice.Text + "')", objConnection);
                        cmdInsertInvoice.ExecuteNonQuery();
                        SqlCommand cmdSelectCmd = new SqlCommand("SELECT SerialNo, Product, Quantity, BatchNo, UnitPrice, TotalPrice FROM ShopInvoice WHERE InvoiceNo == '" + txtInvoice.Text + "'", objConnection);
                        SqlDataAdapter daInvoice = new SqlDataAdapter(cmdSelectCmd.CommandText, objConnection);
                        dsInvoice = new DataSet();

                        daInvoice.Fill(dsInvoice, "Invoice");
                        gridProducts.DataSource = dsInvoice.Tables["Invoice"].DefaultView;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        objConnection.Close();

                    }
                    
                    //gridProducts.FirstDisplayedScrollingRowIndex = gridProducts.RowCount - 1;
                    txtProduct.Clear(); txtQuantity.Clear(); txtxBatchNo.Clear(); txtUnitPrice.Clear();
                    txtSerialNo.Text = Convert.ToString(Convert.ToInt32(txtSerialNo.Text) + 1);
                    txtProduct.Focus();
                    txtTotalProducts.Text = Convert.ToString(Convert.ToInt32(txtSerialNo.Text) - 1);
                    txtTotalPrice.Text = "0";
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objConnection.Open();
            if (txtCustomerName.Text == "" && txtPhone.Text == "" && txtTotalAmount.Text == "0")
            {
                MessageBox.Show("All Fields are Required.", "Message", MessageBoxButtons.OK);
                txtCustomerName.Focus();
            }
            else if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Customer Name Required.", "Message", MessageBoxButtons.OK);
                txtCustomerName.Focus();
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Custommer Phone No. Required.", "Message", MessageBoxButtons.OK);
                txtPhone.Focus();
            }
            else if (txtTotalAmount.Text == "0")
            {
                MessageBox.Show("Total Amount is Zero.", "Message", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    SqlCommand cmdInsertCustomer = new SqlCommand("INSERT INTO ShopCustomer ([InvoiceNo], [CustomerName], [Mobile]) VALUES ('" + txtInvoice.Text + "', '" + txtCustomerName.Text + "','" + txtPhone.Text + "')", objConnection);
                    cmdInsertCustomer.ExecuteNonQuery();
                    SqlCommand cmdInsertAmount = new SqlCommand("INSERT INTO ShopAmount ([InvoiceNo], [TotalAmount]) VALUES ('" + txtInvoice.Text + "','" + txtTotalAmount.Text + "')", objConnection);
                    cmdInsertAmount.ExecuteNonQuery();
                    MessageBox.Show("Record is Entered.", "Message", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    objConnection.Close();

                }
                
            }
            
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();

        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            objConnection.Open();
            try
            {
                if (txtInvoice.Text != "")
                {
                    SqlCommand cmdSelectAmount = new SqlCommand("SELECT SUM(TotalPrice) FROM ShopInvoice WHERE InvoiceNo == '" + txtInvoice.Text + "'", objConnection);
                    double amount = Convert.ToDouble(cmdSelectAmount.ExecuteScalar());
                    txtTotalAmount.Text = amount.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                objConnection.Close();

            }
            
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            #region Logo
            Bitmap bmLogo = Properties.Resources.ZMC_shop;
            Image zmc = bmLogo;
            e.Graphics.DrawImage(zmc, 22, 10);
            #endregion

            #region customer Info
            e.Graphics.DrawString("No. " + txtInvoice.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(650, 110));
            e.Graphics.DrawString("Date And Time: " + lblDateTime.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(22, 110));
            e.Graphics.DrawString(lblCustomerName.Text + " " + txtCustomerName.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(22, 145));
            e.Graphics.DrawString(lblPhone.Text + " " + txtPhone.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.DarkSlateBlue, new Point(22, 180));
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
            #region
            Bitmap bmAddress = Properties.Resources.line3;
            Image imgAddress = bmAddress;
            e.Graphics.DrawImage(imgAddress, 128, 210);
            #endregion
            #region horizontal1
            e.Graphics.DrawImage(line, 20, 230);
            #endregion

            #region Horizontal2
            int rowpositionline = 270;
            for (int i = 0; i <= 16; i++)
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

            for (int i = 0; i < gridProducts.RowCount; i++)
            {
                varSerial = gridProducts.Rows[i].Cells[0].Value.ToString();
                varProduct = gridProducts.Rows[i].Cells[1].Value.ToString();
                varQnty = gridProducts.Rows[i].Cells[2].Value.ToString();
                varBatch = gridProducts.Rows[i].Cells[3].Value.ToString();
                varRate = gridProducts.Rows[i].Cells[4].Value.ToString();
                varTotalPrice = gridProducts.Rows[i].Cells[5].Value.ToString();

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
            Bitmap bmWarranty = Properties.Resources.wrranty_shop;
            Image Warranty = bmWarranty;
            e.Graphics.DrawImage(Warranty, 22, 990);

            #endregion
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridProducts_Scroll(object sender, ScrollEventArgs e)
        {
            //if(gridProducts.Rows.Count > 0)
            //{
            //    gridProducts.FirstDisplayedScrollingRowIndex = gridProducts.RowCount - 1;

            //}
            //else
            //{
            //    gridProducts.ScrollBars = ScrollBars.None;
            //}
        }

        private void txtAdvance_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAdvance.Text == "0")
            {
                txtAdvance.Text = "";
            }
        }

        private void txtbalance_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbalance.Text == "0")
            {
                txtbalance.Text = "";
            }
        }

        private void txtbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        
    }
}
