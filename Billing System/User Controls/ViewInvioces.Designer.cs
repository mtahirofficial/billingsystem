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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle109 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle110 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.dgvInvoiceList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInvoice = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtMedi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sepLine3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblMediName = new System.Windows.Forms.Label();
            this.sepLinetwo = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtQty = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.sepLineOne = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtPhoneNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnViewAll = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panel2.SuspendLayout();
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
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle101.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle101.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle101.NullValue = null;
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoiceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle101;
            this.dgvInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoiceList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle102.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle102.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle102.NullValue = null;
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle102;
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colCustomerName,
            this.colPhoneNo,
            this.colTotalBill});
            dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle103.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle103.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle103.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle103.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle103.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle103.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceList.DefaultCellStyle = dataGridViewCellStyle103;
            this.dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoiceList.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceList.MultiSelect = false;
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.ReadOnly = true;
            dataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle104.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle104.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle104.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle104.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle104;
            dataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle105.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle105.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle105.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle105.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle105.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoiceList.RowsDefaultCellStyle = dataGridViewCellStyle105;
            this.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceList.Size = new System.Drawing.Size(926, 351);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(37, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 458);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInvoice);
            this.panel3.Controls.Add(this.dgvInvoiceList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 351);
            this.panel3.TabIndex = 88;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            dataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle106.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle106.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle106.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle106.NullValue = null;
            dataGridViewCellStyle106.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle106.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle106;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle107.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle107.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle107.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle107.NullValue = null;
            dataGridViewCellStyle107.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle107.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle107;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle108.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle108.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle108.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle108.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle108.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle108.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle108;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            dataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle109.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle109.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle109.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle109.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle109.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle109.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle109;
            dataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle110.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle110.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle110.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle110.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle110.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoice.RowsDefaultCellStyle = dataGridViewCellStyle110;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(926, 351);
            this.dgvInvoice.TabIndex = 57;
            this.dgvInvoice.Visible = false;
            this.dgvInvoice.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInvoice_RowPostPaint);
            this.dgvInvoice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInvoice_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtMedi);
            this.panel2.Controls.Add(this.lblBatch);
            this.panel2.Controls.Add(this.txtBatch);
            this.panel2.Controls.Add(this.sepLine3);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblMediName);
            this.panel2.Controls.Add(this.sepLinetwo);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtSrNo);
            this.panel2.Controls.Add(this.lblSrNo);
            this.panel2.Controls.Add(this.sepLineOne);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 104);
            this.panel2.TabIndex = 87;
            this.panel2.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(851, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMedi
            // 
            this.txtMedi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMedi.Border.Class = "TextBoxBorder";
            this.txtMedi.Border.CornerDiameter = 5;
            this.txtMedi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMedi.FocusHighlightColor = System.Drawing.Color.White;
            this.txtMedi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedi.ForeColor = System.Drawing.Color.Black;
            this.txtMedi.Location = new System.Drawing.Point(0, 52);
            this.txtMedi.MaxLength = 10;
            this.txtMedi.Name = "txtMedi";
            this.txtMedi.PreventEnterBeep = true;
            this.txtMedi.Size = new System.Drawing.Size(378, 33);
            this.txtMedi.TabIndex = 101;
            this.txtMedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBatch
            // 
            this.lblBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(384, 16);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(149, 20);
            this.lblBatch.TabIndex = 92;
            this.lblBatch.Text = "Batch Name";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBatch.Click += new System.EventHandler(this.lblBatch_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBatch.Border.Class = "TextBoxBorder";
            this.txtBatch.Border.CornerDiameter = 5;
            this.txtBatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBatch.FocusHighlightColor = System.Drawing.Color.White;
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.ForeColor = System.Drawing.Color.Black;
            this.txtBatch.Location = new System.Drawing.Point(384, 52);
            this.txtBatch.MaxLength = 10;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.PreventEnterBeep = true;
            this.txtBatch.Size = new System.Drawing.Size(149, 33);
            this.txtBatch.TabIndex = 93;
            this.txtBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sepLine3
            // 
            this.sepLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepLine3.BackColor = System.Drawing.Color.Transparent;
            this.sepLine3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sepLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sepLine3.LineThickness = 1;
            this.sepLine3.Location = new System.Drawing.Point(1, 88);
            this.sepLine3.Name = "sepLine3";
            this.sepLine3.Size = new System.Drawing.Size(920, 10);
            this.sepLine3.TabIndex = 100;
            this.sepLine3.TabStop = false;
            this.sepLine3.Transparency = 255;
            this.sepLine3.Vertical = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(707, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(131, 20);
            this.lblPrice.TabIndex = 98;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRate
            // 
            this.lblRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(619, 16);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(82, 20);
            this.lblRate.TabIndex = 96;
            this.lblRate.Text = "Rate";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(536, 16);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(77, 20);
            this.lblQty.TabIndex = 94;
            this.lblQty.Text = "Qty.";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblMediName
            // 
            this.lblMediName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediName.Location = new System.Drawing.Point(3, 16);
            this.lblMediName.Name = "lblMediName";
            this.lblMediName.Size = new System.Drawing.Size(375, 20);
            this.lblMediName.TabIndex = 91;
            this.lblMediName.Text = "Medicine Name";
            this.lblMediName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sepLinetwo
            // 
            this.sepLinetwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepLinetwo.BackColor = System.Drawing.Color.Transparent;
            this.sepLinetwo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sepLinetwo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sepLinetwo.LineThickness = 1;
            this.sepLinetwo.Location = new System.Drawing.Point(1, 39);
            this.sepLinetwo.Name = "sepLinetwo";
            this.sepLinetwo.Size = new System.Drawing.Size(920, 10);
            this.sepLinetwo.TabIndex = 87;
            this.sepLinetwo.TabStop = false;
            this.sepLinetwo.Transparency = 255;
            this.sepLinetwo.Vertical = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPrice.Border.Class = "TextBoxBorder";
            this.txtPrice.Border.CornerDiameter = 5;
            this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPrice.FocusHighlightColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(712, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PreventEnterBeep = true;
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(133, 33);
            this.txtPrice.TabIndex = 99;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRate
            // 
            this.txtRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtRate.Border.Class = "TextBoxBorder";
            this.txtRate.Border.CornerDiameter = 5;
            this.txtRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtRate.FocusHighlightColor = System.Drawing.Color.White;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.Black;
            this.txtRate.Location = new System.Drawing.Point(624, 52);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.PreventEnterBeep = true;
            this.txtRate.Size = new System.Drawing.Size(82, 33);
            this.txtRate.TabIndex = 97;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtQty.Border.Class = "TextBoxBorder";
            this.txtQty.Border.CornerDiameter = 5;
            this.txtQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtQty.FocusHighlightColor = System.Drawing.Color.White;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(541, 52);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.PreventEnterBeep = true;
            this.txtQty.Size = new System.Drawing.Size(77, 33);
            this.txtQty.TabIndex = 95;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtSrNo
            // 
            // 
            // 
            // 
            this.txtSrNo.Border.Class = "TextBoxBorder";
            this.txtSrNo.Border.CornerDiameter = 5;
            this.txtSrNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSrNo.FocusHighlightColor = System.Drawing.Color.White;
            this.txtSrNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.ForeColor = System.Drawing.Color.Black;
            this.txtSrNo.Location = new System.Drawing.Point(3, 52);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.PreventEnterBeep = true;
            this.txtSrNo.ReadOnly = true;
            this.txtSrNo.Size = new System.Drawing.Size(82, 33);
            this.txtSrNo.TabIndex = 89;
            this.txtSrNo.TabStop = false;
            this.txtSrNo.Text = "1";
            this.txtSrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSrNo.Visible = false;
            // 
            // lblSrNo
            // 
            this.lblSrNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrNo.Location = new System.Drawing.Point(3, 16);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(82, 20);
            this.lblSrNo.TabIndex = 90;
            this.lblSrNo.Text = "Sr #";
            this.lblSrNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSrNo.Visible = false;
            // 
            // sepLineOne
            // 
            this.sepLineOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepLineOne.BackColor = System.Drawing.Color.Transparent;
            this.sepLineOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sepLineOne.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sepLineOne.LineThickness = 1;
            this.sepLineOne.Location = new System.Drawing.Point(3, 3);
            this.sepLineOne.Name = "sepLineOne";
            this.sepLineOne.Size = new System.Drawing.Size(920, 10);
            this.sepLineOne.TabIndex = 88;
            this.sepLineOne.TabStop = false;
            this.sepLineOne.Transparency = 255;
            this.sepLineOne.Vertical = false;
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
            this.txtPhoneNo.Location = new System.Drawing.Point(229, 140);
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
            this.lblPhoneNo.Location = new System.Drawing.Point(225, 101);
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
            this.txtInvoiceNo.Location = new System.Drawing.Point(37, 140);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PreventEnterBeep = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(186, 33);
            this.txtInvoiceNo.TabIndex = 0;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(33, 101);
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
            this.btnSearch.Location = new System.Drawing.Point(517, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
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
            this.btnViewAll.Location = new System.Drawing.Point(630, 137);
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
            this.viewInvoiceToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // viewInvoiceToolStripMenuItem
            // 
            this.viewInvoiceToolStripMenuItem.Name = "viewInvoiceToolStripMenuItem";
            this.viewInvoiceToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.viewInvoiceToolStripMenuItem.Text = "View Invoice";
            this.viewInvoiceToolStripMenuItem.Click += new System.EventHandler(this.viewInvoiceToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(743, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 36);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(856, 137);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 36);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewInvioces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lblPageHeading);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panel1);
            this.Name = "ViewInvioces";
            this.Size = new System.Drawing.Size(1000, 651);
            this.Load += new System.EventHandler(this.ViewInvioces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnBack;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBatch;
        private Bunifu.Framework.UI.BunifuSeparator sepLine3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblMediName;
        private Bunifu.Framework.UI.BunifuSeparator sepLinetwo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQty;
        private System.Windows.Forms.Label lblSrNo;
        private Bunifu.Framework.UI.BunifuSeparator sepLineOne;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMedi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrNo;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}
