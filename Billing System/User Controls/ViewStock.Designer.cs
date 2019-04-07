namespace Billing_System.User_Controls
{
    partial class ViewStock
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
            this.btnViewAll = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtMediName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMediName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMediList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.lblHeading = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.gbNewMedicine = new System.Windows.Forms.GroupBox();
            this.lblNewMedi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtQty = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMedi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.gbNewMedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAll
            // 
            this.btnViewAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnViewAll.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewAll.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(878, 170);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(107, 36);
            this.btnViewAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewAll.TabIndex = 63;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextColor = System.Drawing.Color.White;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(765, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "Serach";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMediName
            // 
            // 
            // 
            // 
            this.txtMediName.Border.Class = "TextBoxBorder";
            this.txtMediName.Border.CornerDiameter = 5;
            this.txtMediName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMediName.FocusHighlightColor = System.Drawing.Color.White;
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediName.ForeColor = System.Drawing.Color.Black;
            this.txtMediName.Location = new System.Drawing.Point(231, 170);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PreventEnterBeep = true;
            this.txtMediName.Size = new System.Drawing.Size(186, 33);
            this.txtMediName.TabIndex = 55;
            // 
            // lblMediName
            // 
            this.lblMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediName.Location = new System.Drawing.Point(227, 131);
            this.lblMediName.Name = "lblMediName";
            this.lblMediName.Size = new System.Drawing.Size(180, 36);
            this.lblMediName.TabIndex = 56;
            this.lblMediName.Text = "Enter medicine name:";
            this.lblMediName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvMediList);
            this.panel1.Location = new System.Drawing.Point(231, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 328);
            this.panel1.TabIndex = 61;
            // 
            // dgvMediList
            // 
            this.dgvMediList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMediList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMediList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMediList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMediList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colCustomerName,
            this.colPhoneNo,
            this.colTotalBill,
            this.Rate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMediList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMediList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMediList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMediList.Location = new System.Drawing.Point(0, 0);
            this.dgvMediList.MultiSelect = false;
            this.dgvMediList.Name = "dgvMediList";
            this.dgvMediList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMediList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMediList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMediList.Size = new System.Drawing.Size(754, 328);
            this.dgvMediList.TabIndex = 21;
            this.dgvMediList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMediList_RowPostPaint);
            this.dgvMediList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMediList_KeyDown);
            this.dgvMediList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMediList_MouseDown);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "ID";
            this.colInvoiceNo.HeaderText = "ID #";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "MedicineName";
            this.colCustomerName.HeaderText = "Medicine Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.DataPropertyName = "BatchName";
            this.colPhoneNo.HeaderText = "Batch #";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            // 
            // colTotalBill
            // 
            this.colTotalBill.DataPropertyName = "Quantity";
            this.colTotalBill.HeaderText = "Quantity";
            this.colTotalBill.Name = "colTotalBill";
            this.colTotalBill.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // lblPageHeading
            // 
            this.lblPageHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPageHeading.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeading.Location = new System.Drawing.Point(500, 0);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(205, 35);
            this.lblPageHeading.TabIndex = 57;
            this.lblPageHeading.Text = "Medicine Record";
            this.lblPageHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblHeading.TabIndex = 58;
            this.lblHeading.TabStop = false;
            this.lblHeading.Text = "<b><font size=\"+6\">Zahid<font color=\"#69C9E9\"> Medical Store</font></font></b>";
            // 
            // menuDGV
            // 
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(132, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(10, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 36);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbNewMedicine
            // 
            this.gbNewMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNewMedicine.Controls.Add(this.lblNewMedi);
            this.gbNewMedicine.Controls.Add(this.btnUpdate);
            this.gbNewMedicine.Controls.Add(this.lblID);
            this.gbNewMedicine.Controls.Add(this.label1);
            this.gbNewMedicine.Controls.Add(this.lblRate);
            this.gbNewMedicine.Controls.Add(this.txtRate);
            this.gbNewMedicine.Controls.Add(this.lblBatch);
            this.gbNewMedicine.Controls.Add(this.txtQty);
            this.gbNewMedicine.Controls.Add(this.lblQty);
            this.gbNewMedicine.Controls.Add(this.txtBatch);
            this.gbNewMedicine.Controls.Add(this.txtID);
            this.gbNewMedicine.Controls.Add(this.txtMedi);
            this.gbNewMedicine.Location = new System.Drawing.Point(10, 131);
            this.gbNewMedicine.Name = "gbNewMedicine";
            this.gbNewMedicine.Size = new System.Drawing.Size(215, 410);
            this.gbNewMedicine.TabIndex = 65;
            this.gbNewMedicine.TabStop = false;
            // 
            // lblNewMedi
            // 
            this.lblNewMedi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewMedi.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMedi.Location = new System.Drawing.Point(3, 9);
            this.lblNewMedi.Name = "lblNewMedi";
            this.lblNewMedi.Size = new System.Drawing.Size(209, 35);
            this.lblNewMedi.TabIndex = 33;
            this.lblNewMedi.Text = "Update Medicine";
            this.lblNewMedi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 33);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Medicine Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(6, 297);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(141, 28);
            this.lblRate.TabIndex = 29;
            this.lblRate.Text = "Rate :";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRate
            // 
            // 
            // 
            // 
            this.txtRate.Border.Class = "TextBoxBorder";
            this.txtRate.Border.CornerDiameter = 5;
            this.txtRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtRate.FocusHighlightColor = System.Drawing.Color.White;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.Black;
            this.txtRate.Location = new System.Drawing.Point(10, 328);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.PreventEnterBeep = true;
            this.txtRate.Size = new System.Drawing.Size(190, 33);
            this.txtRate.TabIndex = 30;
            // 
            // lblBatch
            // 
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(6, 163);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(141, 28);
            this.lblBatch.TabIndex = 25;
            this.lblBatch.Text = "Batch Name :";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.Border.Class = "TextBoxBorder";
            this.txtQty.Border.CornerDiameter = 5;
            this.txtQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtQty.FocusHighlightColor = System.Drawing.Color.White;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(10, 261);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.PreventEnterBeep = true;
            this.txtQty.Size = new System.Drawing.Size(190, 33);
            this.txtQty.TabIndex = 28;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 230);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(141, 28);
            this.lblQty.TabIndex = 27;
            this.lblQty.Text = "Quantity :";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBatch
            // 
            // 
            // 
            // 
            this.txtBatch.Border.Class = "TextBoxBorder";
            this.txtBatch.Border.CornerDiameter = 5;
            this.txtBatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBatch.FocusHighlightColor = System.Drawing.Color.White;
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.ForeColor = System.Drawing.Color.Black;
            this.txtBatch.Location = new System.Drawing.Point(10, 194);
            this.txtBatch.MaxLength = 10;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.PreventEnterBeep = true;
            this.txtBatch.Size = new System.Drawing.Size(190, 33);
            this.txtBatch.TabIndex = 26;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerDiameter = 5;
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtID.FocusHighlightColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(59, 60);
            this.txtID.Name = "txtID";
            this.txtID.PreventEnterBeep = true;
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(141, 33);
            this.txtID.TabIndex = 21;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMedi
            // 
            // 
            // 
            // 
            this.txtMedi.Border.Class = "TextBoxBorder";
            this.txtMedi.Border.CornerDiameter = 5;
            this.txtMedi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMedi.FocusHighlightColor = System.Drawing.Color.White;
            this.txtMedi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedi.ForeColor = System.Drawing.Color.Black;
            this.txtMedi.Location = new System.Drawing.Point(10, 127);
            this.txtMedi.MaxLength = 32;
            this.txtMedi.Name = "txtMedi";
            this.txtMedi.PreventEnterBeep = true;
            this.txtMedi.Size = new System.Drawing.Size(190, 33);
            this.txtMedi.TabIndex = 24;
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbNewMedicine);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.lblMediName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPageHeading);
            this.Controls.Add(this.lblHeading);
            this.Name = "ViewStock";
            this.Size = new System.Drawing.Size(1000, 553);
            this.Load += new System.EventHandler(this.ViewStock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.gbNewMedicine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnViewAll;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMediName;
        private System.Windows.Forms.Label lblMediName;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMediList;
        private System.Windows.Forms.Label lblPageHeading;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblHeading;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private System.Windows.Forms.GroupBox gbNewMedicine;
        private System.Windows.Forms.Label lblNewMedi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRate;
        private System.Windows.Forms.Label lblBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQty;
        private System.Windows.Forms.Label lblQty;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMedi;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}
