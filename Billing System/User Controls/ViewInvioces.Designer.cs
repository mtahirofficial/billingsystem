namespace Billing_System.User_Controls
{
    partial class ViewInvioces
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.dgvInvoiceList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnViewAll = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageHeading
            // 
            this.lblPageHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPageHeading.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeading.Location = new System.Drawing.Point(500, 0);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(205, 35);
            this.lblPageHeading.TabIndex = 0;
            this.lblPageHeading.Text = "Invoice Record";
            this.lblPageHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoiceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoiceList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colCustomerName,
            this.colPhoneNo,
            this.colTotalBill});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoiceList.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceList.MultiSelect = false;
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoiceList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceList.Size = new System.Drawing.Size(926, 328);
            this.dgvInvoiceList.TabIndex = 21;
            this.dgvInvoiceList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInvoiceList_RowPostPaint);
            this.dgvInvoiceList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInvoiceList_MouseDown);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "Invoice #";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.DataPropertyName = "Mobile";
            this.colPhoneNo.HeaderText = "Phone #";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            // 
            // colTotalBill
            // 
            this.colTotalBill.DataPropertyName = "TotalAmount";
            this.colTotalBill.HeaderText = "Total Bill";
            this.colTotalBill.Name = "colTotalBill";
            this.colTotalBill.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvInvoiceList);
            this.panel1.Location = new System.Drawing.Point(37, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 328);
            this.panel1.TabIndex = 22;
            // 
            // txtPhoneNo
            // 
            // 
            // 
            // 
            this.txtPhoneNo.Border.Class = "TextBoxBorder";
            this.txtPhoneNo.Border.CornerDiameter = 5;
            this.txtPhoneNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPhoneNo.FocusHighlightColor = System.Drawing.Color.White;
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNo.Location = new System.Drawing.Point(229, 159);
            this.txtPhoneNo.MaxLength = 11;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PreventEnterBeep = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(186, 33);
            this.txtPhoneNo.TabIndex = 1;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(225, 120);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(180, 36);
            this.lblPhoneNo.TabIndex = 1;
            this.lblPhoneNo.Text = "Enter phone number:";
            this.lblPhoneNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.Border.Class = "TextBoxBorder";
            this.txtInvoiceNo.Border.CornerDiameter = 5;
            this.txtInvoiceNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtInvoiceNo.FocusHighlightColor = System.Drawing.Color.White;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceNo.Location = new System.Drawing.Point(37, 159);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PreventEnterBeep = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(186, 33);
            this.txtInvoiceNo.TabIndex = 0;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(33, 120);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(180, 36);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Enter invoice number:";
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(743, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Serach";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnViewAll.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewAll.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(856, 156);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(107, 36);
            this.btnViewAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewAll.TabIndex = 54;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextColor = System.Drawing.Color.White;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInvoiceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // viewInvoiceToolStripMenuItem
            // 
            this.viewInvoiceToolStripMenuItem.Name = "viewInvoiceToolStripMenuItem";
            this.viewInvoiceToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.viewInvoiceToolStripMenuItem.Text = "View Invoice";
            this.viewInvoiceToolStripMenuItem.Click += new System.EventHandler(this.viewInvoiceToolStripMenuItem_Click);
            // 
            // lblHeading
            // 
            // 
            // 
            // 
            this.lblHeading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(10, 6);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(402, 84);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.TabStop = false;
            this.lblHeading.Text = "<b><font size=\"+6\">Zahid<font color=\"#69C9E9\"> Medical Store</font></font></b>";
            // 
            // ViewInvioces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPageHeading);
            this.Controls.Add(this.lblHeading);
            this.Name = "ViewInvioces";
            this.Size = new System.Drawing.Size(1000, 554);
            this.Load += new System.EventHandler(this.ViewInvioces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPageHeading;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoiceList;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBill;
        private DevComponents.DotNetBar.ButtonX btnViewAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewInvoiceToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblHeading;
    }
}
