namespace Billing_System
{
    partial class SupplyInvoice
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

        #region Windows Form Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyInvoice));
            this.lblProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUnitPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridSupplyInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTotalPrice = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtProduct = new System.Windows.Forms.RichTextBox();
            this.txtTotalPrice = new System.Windows.Forms.RichTextBox();
            this.txtUnitPrice = new System.Windows.Forms.RichTextBox();
            this.txtxBatchNo = new System.Windows.Forms.RichTextBox();
            this.txtSerialNo = new System.Windows.Forms.RichTextBox();
            this.txtQuantity = new System.Windows.Forms.RichTextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblAdvance = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBalance = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTotalProducts = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAdvance = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblTotalAmount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtbalance = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTotalAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTotalProducts = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblBatch = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSerialNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQuantity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCustomerName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDateTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCustomerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtAddress = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.previewSupplyInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printSupplyInvoice = new System.Drawing.Printing.PrintDocument();
            this.btnInvoice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtInvoice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblInvoice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplyInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Honeydew;
            this.lblProduct.Location = new System.Drawing.Point(58, 16);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(347, 19);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Honeydew;
            this.lblUnitPrice.Location = new System.Drawing.Point(554, 16);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(99, 19);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Honeydew;
            this.lblPrice.Location = new System.Drawing.Point(653, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 19);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Total Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bunifuSeparator3);
            this.groupBox1.Controls.Add(this.bunifuSeparator2);
            this.groupBox1.Controls.Add(this.panelGrid);
            this.groupBox1.Controls.Add(this.btnTotalPrice);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtxBatchNo);
            this.groupBox1.Controls.Add(this.txtSerialNo);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.bunifuSeparator1);
            this.groupBox1.Controls.Add(this.lblAdvance);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblTotalProducts);
            this.groupBox1.Controls.Add(this.txtAdvance);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.txtbalance);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.txtTotalProducts);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblBatch);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblSerialNo);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Location = new System.Drawing.Point(202, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 79);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(775, 12);
            this.bunifuSeparator3.TabIndex = 19;
            this.bunifuSeparator3.TabStop = false;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 347);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(775, 12);
            this.bunifuSeparator2.TabIndex = 18;
            this.bunifuSeparator2.TabStop = false;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panelGrid
            // 
            this.panelGrid.AutoScroll = true;
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.panelGrid.Controls.Add(this.gridSupplyInvoice);
            this.panelGrid.Location = new System.Drawing.Point(8, 87);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(761, 260);
            this.panelGrid.TabIndex = 17;
            // 
            // gridSupplyInvoice
            // 
            this.gridSupplyInvoice.AllowUserToAddRows = false;
            this.gridSupplyInvoice.AllowUserToDeleteRows = false;
            this.gridSupplyInvoice.AllowUserToResizeColumns = false;
            this.gridSupplyInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridSupplyInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSupplyInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSupplyInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSupplyInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.gridSupplyInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplyInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplyInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSupplyInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSupplyInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.Product,
            this.Quantity,
            this.BatchNo,
            this.UnitPrice,
            this.Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplyInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSupplyInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSupplyInvoice.DoubleBuffered = true;
            this.gridSupplyInvoice.EnableHeadersVisualStyles = false;
            this.gridSupplyInvoice.GridColor = System.Drawing.Color.PaleTurquoise;
            this.gridSupplyInvoice.HeaderBgColor = System.Drawing.Color.White;
            this.gridSupplyInvoice.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gridSupplyInvoice.Location = new System.Drawing.Point(0, 0);
            this.gridSupplyInvoice.Name = "gridSupplyInvoice";
            this.gridSupplyInvoice.ReadOnly = true;
            this.gridSupplyInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplyInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridSupplyInvoice.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridSupplyInvoice.Size = new System.Drawing.Size(761, 260);
            this.gridSupplyInvoice.TabIndex = 12;
            this.gridSupplyInvoice.TabStop = false;
            this.gridSupplyInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            this.gridSupplyInvoice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gridSupplyInvoice_Scroll);
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SerialNo.DataPropertyName = "SerialNo";
            this.SerialNo.HeaderText = "Serial No";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 94;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 87;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 92;
            // 
            // BatchNo
            // 
            this.BatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BatchNo.DataPropertyName = "BatchNo";
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            this.BatchNo.Width = 95;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 99;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "TotalPrice";
            this.Price.HeaderText = "Total Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 104;
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.ActiveBorderThickness = 1;
            this.btnTotalPrice.ActiveCornerRadius = 10;
            this.btnTotalPrice.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTotalPrice.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotalPrice.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnTotalPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalPrice.BackgroundImage")));
            this.btnTotalPrice.ButtonText = "Total Price";
            this.btnTotalPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTotalPrice.IdleBorderThickness = 1;
            this.btnTotalPrice.IdleCornerRadius = 10;
            this.btnTotalPrice.IdleFillColor = System.Drawing.Color.White;
            this.btnTotalPrice.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTotalPrice.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalPrice.Location = new System.Drawing.Point(579, 354);
            this.btnTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(188, 38);
            this.btnTotalPrice.TabIndex = 14;
            this.btnTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtProduct.Location = new System.Drawing.Point(58, 48);
            this.txtProduct.MaxLength = 38;
            this.txtProduct.Multiline = false;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(347, 30);
            this.txtProduct.TabIndex = 7;
            this.txtProduct.Text = "";
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtTotalPrice.Location = new System.Drawing.Point(654, 48);
            this.txtTotalPrice.Multiline = false;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(113, 30);
            this.txtTotalPrice.TabIndex = 11;
            this.txtTotalPrice.TabStop = false;
            this.txtTotalPrice.Text = "";
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            this.txtTotalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPrice_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtUnitPrice.Location = new System.Drawing.Point(554, 48);
            this.txtUnitPrice.MaxLength = 5;
            this.txtUnitPrice.Multiline = false;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(99, 30);
            this.txtUnitPrice.TabIndex = 10;
            this.txtUnitPrice.Text = "";
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitPrice_KeyDown);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // txtxBatchNo
            // 
            this.txtxBatchNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxBatchNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtxBatchNo.Location = new System.Drawing.Point(455, 48);
            this.txtxBatchNo.MaxLength = 10;
            this.txtxBatchNo.Multiline = false;
            this.txtxBatchNo.Name = "txtxBatchNo";
            this.txtxBatchNo.Size = new System.Drawing.Size(98, 30);
            this.txtxBatchNo.TabIndex = 9;
            this.txtxBatchNo.Text = "";
            this.txtxBatchNo.TextChanged += new System.EventHandler(this.txtxBatchNo_TextChanged);
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSerialNo.Location = new System.Drawing.Point(9, 48);
            this.txtSerialNo.Multiline = false;
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(48, 30);
            this.txtSerialNo.TabIndex = 6;
            this.txtSerialNo.TabStop = false;
            this.txtSerialNo.Text = "";
            this.txtSerialNo.TextChanged += new System.EventHandler(this.txtSerialNo_TextChanged);
            this.txtSerialNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNo_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtQuantity.Location = new System.Drawing.Point(406, 48);
            this.txtQuantity.MaxLength = 2;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(48, 30);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 35);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(775, 12);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.TabStop = false;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox5_KeyPress);
            // 
            // lblAdvance
            // 
            this.lblAdvance.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.ForeColor = System.Drawing.Color.Honeydew;
            this.lblAdvance.Location = new System.Drawing.Point(381, 396);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(79, 20);
            this.lblAdvance.TabIndex = 15;
            this.lblAdvance.Text = "Advance:";
            this.lblAdvance.Click += new System.EventHandler(this.lblAdvance_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Honeydew;
            this.lblBalance.Location = new System.Drawing.Point(578, 396);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(79, 20);
            this.lblBalance.TabIndex = 16;
            this.lblBalance.Text = "Balance:";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.Honeydew;
            this.lblTotalProducts.Location = new System.Drawing.Point(13, 364);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(124, 20);
            this.lblTotalProducts.TabIndex = 12;
            this.lblTotalProducts.Text = "Toal Products:";
            // 
            // txtAdvance
            // 
            this.txtAdvance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.ForeColor = System.Drawing.Color.Red;
            this.txtAdvance.Location = new System.Drawing.Point(468, 393);
            this.txtAdvance.MaxLength = 10;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(104, 26);
            this.txtAdvance.TabIndex = 15;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdvance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdvance_MouseClick);
            this.txtAdvance.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Honeydew;
            this.lblTotalAmount.Location = new System.Drawing.Point(342, 364);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(121, 20);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtbalance
            // 
            this.txtbalance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.Color.Red;
            this.txtbalance.Location = new System.Drawing.Point(663, 393);
            this.txtbalance.MaxLength = 10;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(104, 26);
            this.txtbalance.TabIndex = 16;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbalance_MouseClick);
            this.txtbalance.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.txtTotalAmount.Location = new System.Drawing.Point(468, 361);
            this.txtTotalAmount.MaxLength = 11;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(104, 26);
            this.txtTotalAmount.TabIndex = 13;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            // 
            // txtTotalProducts
            // 
            this.txtTotalProducts.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProducts.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalProducts.Location = new System.Drawing.Point(143, 361);
            this.txtTotalProducts.Name = "txtTotalProducts";
            this.txtTotalProducts.Size = new System.Drawing.Size(68, 26);
            this.txtTotalProducts.TabIndex = 12;
            this.txtTotalProducts.TabStop = false;
            this.txtTotalProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalProducts.TextChanged += new System.EventHandler(this.txtTotalProducts_TextChanged);
            this.txtTotalProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            // 
            // lblBatch
            // 
            this.lblBatch.BackColor = System.Drawing.Color.Transparent;
            this.lblBatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.ForeColor = System.Drawing.Color.Honeydew;
            this.lblBatch.Location = new System.Drawing.Point(455, 16);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(98, 19);
            this.lblBatch.TabIndex = 9;
            this.lblBatch.Text = "Batch No.";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSerialNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.ForeColor = System.Drawing.Color.Honeydew;
            this.lblSerialNo.Location = new System.Drawing.Point(9, 16);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(48, 19);
            this.lblSerialNo.TabIndex = 6;
            this.lblSerialNo.Text = "Sr.#";
            this.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Honeydew;
            this.lblQuantity.Location = new System.Drawing.Point(406, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(48, 19);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Qty.";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Honeydew;
            this.lblCustomerName.Location = new System.Drawing.Point(215, 106);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(142, 20);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Honeydew;
            this.lblAddress.Location = new System.Drawing.Point(274, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Honeydew;
            this.lblDateTime.Location = new System.Drawing.Point(738, 66);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(240, 26);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Date And Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtCustomerName.Location = new System.Drawing.Point(365, 103);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(375, 27);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtAddress.Location = new System.Drawing.Point(365, 137);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(375, 27);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // previewSupplyInvoice
            // 
            this.previewSupplyInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewSupplyInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewSupplyInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previewSupplyInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.previewSupplyInvoice.Enabled = true;
            this.previewSupplyInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("previewSupplyInvoice.Icon")));
            this.previewSupplyInvoice.Name = "previewSupplyInvoice";
            this.previewSupplyInvoice.Visible = false;
            this.previewSupplyInvoice.Load += new System.EventHandler(this.previewSupplyInvoice_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printSupplyInvoice
            // 
            this.printSupplyInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSupplyInvoice_PrintPage);
            // 
            // btnInvoice
            // 
            this.btnInvoice.AutoSize = true;
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.Honeydew;
            this.btnInvoice.Location = new System.Drawing.Point(418, 0);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(341, 54);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "Supply Invoice";
            // 
            // txtInvoice
            // 
            this.txtInvoice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtInvoice.Location = new System.Drawing.Point(365, 69);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(107, 26);
            this.txtInvoice.TabIndex = 1;
            this.txtInvoice.TabStop = false;
            this.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoice.TextChanged += new System.EventHandler(this.txtInvoice_TextChanged);
            this.txtInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoice_KeyPress);
            // 
            // lblInvoice
            // 
            this.lblInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.Color.Honeydew;
            this.lblInvoice.Location = new System.Drawing.Point(256, 71);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(98, 20);
            this.lblInvoice.TabIndex = 1;
            this.lblInvoice.Text = "Invoice No.";
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(613, 611);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnSave.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(115, 48);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.Honeydew;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClose.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(855, 611);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnClose.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(115, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.Honeydew;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 90D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(492, 611);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnPrint.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(115, 48);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.Honeydew;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClear.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClear.Iconimage")));
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(734, 611);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnClear.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(115, 48);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.Honeydew;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SupplyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 671);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.btnInvoice);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "SupplyInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplyInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUnitPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTotalPrice;
        private System.Windows.Forms.RichTextBox txtProduct;
        private System.Windows.Forms.RichTextBox txtTotalPrice;
        private System.Windows.Forms.RichTextBox txtUnitPrice;
        private System.Windows.Forms.RichTextBox txtxBatchNo;
        private System.Windows.Forms.RichTextBox txtSerialNo;
        private System.Windows.Forms.RichTextBox txtQuantity;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAdvance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBalance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalProducts;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAdvance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalAmount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtbalance;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotalAmount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotalProducts;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBatch;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSerialNo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCustomerName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDateTime;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCustomerName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAddress;
        private System.Windows.Forms.PrintPreviewDialog previewSupplyInvoice;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printSupplyInvoice;
        private Bunifu.Framework.UI.BunifuCustomLabel btnInvoice;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInvoice;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInvoice;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridSupplyInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panelGrid;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}