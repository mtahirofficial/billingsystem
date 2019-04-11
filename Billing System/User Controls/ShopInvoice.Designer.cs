using System;
using System.Drawing;
using System.Windows.Forms;

namespace Billing_System.User_Controls
{
    partial class ShopInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopInvoice));
            this.lblShopInvoice = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblHeading = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.sepLineOne = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.sepLinetwo = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMediName = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.sepLine3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelMediList = new System.Windows.Forms.Panel();
            this.dgvMediList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MediName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtQty = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAdvance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtInvoice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtItems = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.txtRate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMediName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Panadol = new DevComponents.Editors.ComboItem();
            this.Bludol = new DevComponents.Editors.ComboItem();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRemainingStock = new System.Windows.Forms.Label();
            this.txtRemainingStock = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelMediList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShopInvoice
            // 
            this.lblShopInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblShopInvoice.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopInvoice.Location = new System.Drawing.Point(500, 0);
            this.lblShopInvoice.Name = "lblShopInvoice";
            this.lblShopInvoice.Size = new System.Drawing.Size(167, 35);
            this.lblShopInvoice.TabIndex = 0;
            this.lblShopInvoice.Text = "Shop Invoice";
            this.lblShopInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoice
            // 
            this.lblInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(771, 51);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(94, 36);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Invoice # :";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Blue;
            this.lblDateTime.Location = new System.Drawing.Point(755, 10);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(242, 36);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblHeading.Text = "<b><font size=\"+6\">Zahid<font color=\"#69C9E9\"> Medical Store</font></font></b>";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(225, 36);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter customer name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(501, 99);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(225, 36);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Enter customer phone No :";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sepLineOne
            // 
            this.sepLineOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepLineOne.BackColor = System.Drawing.Color.Transparent;
            this.sepLineOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sepLineOne.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sepLineOne.LineThickness = 1;
            this.sepLineOne.Location = new System.Drawing.Point(42, 173);
            this.sepLineOne.Name = "sepLineOne";
            this.sepLineOne.Size = new System.Drawing.Size(920, 10);
            this.sepLineOne.TabIndex = 2;
            this.sepLineOne.TabStop = false;
            this.sepLineOne.Transparency = 255;
            this.sepLineOne.Vertical = false;
            // 
            // lblSrNo
            // 
            this.lblSrNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrNo.Location = new System.Drawing.Point(42, 186);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(82, 20);
            this.lblSrNo.TabIndex = 3;
            this.lblSrNo.Text = "Sr #";
            this.lblSrNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSrNo.Visible = false;
            // 
            // sepLinetwo
            // 
            this.sepLinetwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepLinetwo.BackColor = System.Drawing.Color.Transparent;
            this.sepLinetwo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sepLinetwo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sepLinetwo.LineThickness = 1;
            this.sepLinetwo.Location = new System.Drawing.Point(40, 209);
            this.sepLinetwo.Name = "sepLinetwo";
            this.sepLinetwo.Size = new System.Drawing.Size(920, 10);
            this.sepLinetwo.TabIndex = 2;
            this.sepLinetwo.TabStop = false;
            this.sepLinetwo.Transparency = 255;
            this.sepLinetwo.Vertical = false;
            // 
            // lblMediName
            // 
            this.lblMediName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediName.Location = new System.Drawing.Point(38, 186);
            this.lblMediName.Name = "lblMediName";
            this.lblMediName.Size = new System.Drawing.Size(457, 20);
            this.lblMediName.TabIndex = 4;
            this.lblMediName.Text = "Medicine Name";
            this.lblMediName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatch
            // 
            this.lblBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(502, 186);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(149, 20);
            this.lblBatch.TabIndex = 5;
            this.lblBatch.Text = "Batch Name";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(658, 186);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(77, 20);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Qty.";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRate
            // 
            this.lblRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(741, 186);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(82, 20);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Rate";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(829, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(131, 20);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sepLine3
            // 
            this.sepLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepLine3.BackColor = System.Drawing.Color.Transparent;
            this.sepLine3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sepLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sepLine3.LineThickness = 1;
            this.sepLine3.Location = new System.Drawing.Point(40, 258);
            this.sepLine3.Name = "sepLine3";
            this.sepLine3.Size = new System.Drawing.Size(920, 10);
            this.sepLine3.TabIndex = 35;
            this.sepLine3.TabStop = false;
            this.sepLine3.Transparency = 255;
            this.sepLine3.Vertical = false;
            // 
            // panelMediList
            // 
            this.panelMediList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMediList.AutoScroll = true;
            this.panelMediList.Controls.Add(this.dgvMediList);
            this.panelMediList.Location = new System.Drawing.Point(42, 274);
            this.panelMediList.Name = "panelMediList";
            this.panelMediList.Size = new System.Drawing.Size(920, 265);
            this.panelMediList.TabIndex = 36;
            // 
            // dgvMediList
            // 
            this.dgvMediList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMediList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMediList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMediList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMediList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MediName,
            this.Batch,
            this.Quantity,
            this.Rate,
            this.Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMediList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMediList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMediList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMediList.Location = new System.Drawing.Point(0, 0);
            this.dgvMediList.MultiSelect = false;
            this.dgvMediList.Name = "dgvMediList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMediList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMediList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMediList.Size = new System.Drawing.Size(920, 265);
            this.dgvMediList.TabIndex = 9;
            this.dgvMediList.TabStop = false;
            this.dgvMediList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMediList_CellEndEdit);
            this.dgvMediList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMediList_DataBindingComplete);
            this.dgvMediList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMediList_RowPostPaint);
            this.dgvMediList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMediList_KeyDown);
            this.dgvMediList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMediList_MouseDown);
            // 
            // MediName
            // 
            this.MediName.DataPropertyName = "MedicineName";
            this.MediName.HeaderText = "Medicine Name";
            this.MediName.Name = "MediName";
            // 
            // Batch
            // 
            this.Batch.DataPropertyName = "Batch";
            this.Batch.HeaderText = "Batch";
            this.Batch.Name = "Batch";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(42, 548);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(107, 36);
            this.lblItems.TabIndex = 10;
            this.lblItems.Text = "Total Items :";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBill.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.Color.Red;
            this.lblTotalBill.Location = new System.Drawing.Point(46, 626);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(174, 36);
            this.lblTotalBill.TabIndex = 14;
            this.lblTotalBill.Text = "0";
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdvance
            // 
            this.lblAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdvance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(706, 545);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(97, 29);
            this.lblAdvance.TabIndex = 12;
            this.lblAdvance.Text = "Advance :";
            this.lblAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(721, 580);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(82, 29);
            this.lblBalance.TabIndex = 13;
            this.lblBalance.Text = "Balance :";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuDGV
            // 
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(132, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerDiameter = 5;
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPhone.FocusHighlightColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(505, 138);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PreventEnterBeep = true;
            this.txtPhone.Size = new System.Drawing.Size(457, 33);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
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
            this.txtSrNo.Location = new System.Drawing.Point(42, 222);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.PreventEnterBeep = true;
            this.txtSrNo.ReadOnly = true;
            this.txtSrNo.Size = new System.Drawing.Size(82, 33);
            this.txtSrNo.TabIndex = 3;
            this.txtSrNo.TabStop = false;
            this.txtSrNo.Text = "1";
            this.txtSrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrNo_KeyPress);
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
            this.txtBatch.Location = new System.Drawing.Point(502, 222);
            this.txtBatch.MaxLength = 10;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.PreventEnterBeep = true;
            this.txtBatch.Size = new System.Drawing.Size(149, 33);
            this.txtBatch.TabIndex = 5;
            this.txtBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
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
            this.txtQty.Location = new System.Drawing.Point(658, 222);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.PreventEnterBeep = true;
            this.txtQty.Size = new System.Drawing.Size(77, 33);
            this.txtQty.TabIndex = 6;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBalance.Border.Class = "TextBoxBorder";
            this.txtBalance.Border.CornerDiameter = 5;
            this.txtBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBalance.FocusHighlightColor = System.Drawing.Color.White;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Location = new System.Drawing.Point(809, 580);
            this.txtBalance.MaxLength = 7;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PreventEnterBeep = true;
            this.txtBalance.Size = new System.Drawing.Size(149, 33);
            this.txtBalance.TabIndex = 13;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBalance_MouseClick);
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
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
            this.txtPrice.Location = new System.Drawing.Point(829, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PreventEnterBeep = true;
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(133, 33);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAdvance.Border.Class = "TextBoxBorder";
            this.txtAdvance.Border.CornerDiameter = 5;
            this.txtAdvance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtAdvance.FocusHighlightColor = System.Drawing.Color.White;
            this.txtAdvance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.ForeColor = System.Drawing.Color.Black;
            this.txtAdvance.Location = new System.Drawing.Point(809, 545);
            this.txtAdvance.MaxLength = 7;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.PreventEnterBeep = true;
            this.txtAdvance.Size = new System.Drawing.Size(149, 33);
            this.txtAdvance.TabIndex = 12;
            this.txtAdvance.Text = "0";
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdvance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdvance_MouseClick);
            this.txtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvance_KeyPress);
            // 
            // txtInvoice
            // 
            this.txtInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtInvoice.Border.Class = "TextBoxBorder";
            this.txtInvoice.Border.CornerDiameter = 5;
            this.txtInvoice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtInvoice.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.txtInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.txtInvoice.Location = new System.Drawing.Point(871, 51);
            this.txtInvoice.MaxLength = 5;
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.PreventEnterBeep = true;
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(91, 33);
            this.txtInvoice.TabIndex = 0;
            this.txtInvoice.TabStop = false;
            this.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(659, 626);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(172, 36);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Save/Print";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(837, 626);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtItems
            // 
            this.txtItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtItems.Border.Class = "TextBoxBorder";
            this.txtItems.Border.CornerDiameter = 5;
            this.txtItems.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtItems.FocusHighlightColor = System.Drawing.Color.White;
            this.txtItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.ForeColor = System.Drawing.Color.Black;
            this.txtItems.Location = new System.Drawing.Point(155, 553);
            this.txtItems.Name = "txtItems";
            this.txtItems.PreventEnterBeep = true;
            this.txtItems.ReadOnly = true;
            this.txtItems.Size = new System.Drawing.Size(126, 33);
            this.txtItems.TabIndex = 10;
            this.txtItems.TabStop = false;
            this.txtItems.Text = "0";
            this.txtItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItems_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(528, 626);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 36);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtRate.Location = new System.Drawing.Point(741, 222);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.PreventEnterBeep = true;
            this.txtRate.Size = new System.Drawing.Size(82, 33);
            this.txtRate.TabIndex = 7;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerDiameter = 5;
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtName.FocusHighlightColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(42, 138);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(457, 33);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // cbMediName
            // 
            this.cbMediName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMediName.DisplayMember = "Text";
            this.cbMediName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMediName.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.cbMediName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMediName.FormattingEnabled = true;
            this.cbMediName.ItemHeight = 27;
            this.cbMediName.Items.AddRange(new object[] {
            this.Panadol,
            this.Bludol});
            this.cbMediName.Location = new System.Drawing.Point(42, 222);
            this.cbMediName.Name = "cbMediName";
            this.cbMediName.Size = new System.Drawing.Size(454, 33);
            this.cbMediName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMediName.TabIndex = 37;
            this.cbMediName.SelectedIndexChanged += new System.EventHandler(this.cbMediName_SelectedIndexChanged);
            this.cbMediName.Leave += new System.EventHandler(this.cbMediName_Leave_1);
            // 
            // Panadol
            // 
            this.Panadol.Text = "Panadol";
            // 
            // Bludol
            // 
            this.Bludol.Text = "Bludol";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(324, 540);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(104, 20);
            this.lblStock.TabIndex = 38;
            this.lblStock.Text = "Stock Qty.";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStock.Visible = false;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtStock.Border.Class = "TextBoxBorder";
            this.txtStock.Border.CornerDiameter = 5;
            this.txtStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtStock.FocusHighlightColor = System.Drawing.Color.White;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(324, 589);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.PreventEnterBeep = true;
            this.txtStock.Size = new System.Drawing.Size(104, 33);
            this.txtStock.TabIndex = 39;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.Visible = false;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // lblRemainingStock
            // 
            this.lblRemainingStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRemainingStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingStock.Location = new System.Drawing.Point(452, 540);
            this.lblRemainingStock.Name = "lblRemainingStock";
            this.lblRemainingStock.Size = new System.Drawing.Size(104, 44);
            this.lblRemainingStock.TabIndex = 40;
            this.lblRemainingStock.Text = "Remaining Stock";
            this.lblRemainingStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemainingStock.Visible = false;
            // 
            // txtRemainingStock
            // 
            this.txtRemainingStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtRemainingStock.Border.Class = "TextBoxBorder";
            this.txtRemainingStock.Border.CornerDiameter = 5;
            this.txtRemainingStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtRemainingStock.FocusHighlightColor = System.Drawing.Color.White;
            this.txtRemainingStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingStock.ForeColor = System.Drawing.Color.Black;
            this.txtRemainingStock.Location = new System.Drawing.Point(452, 589);
            this.txtRemainingStock.MaxLength = 10;
            this.txtRemainingStock.Name = "txtRemainingStock";
            this.txtRemainingStock.PreventEnterBeep = true;
            this.txtRemainingStock.Size = new System.Drawing.Size(104, 33);
            this.txtRemainingStock.TabIndex = 41;
            this.txtRemainingStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRemainingStock.Visible = false;
            // 
            // ShopInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRemainingStock);
            this.Controls.Add(this.txtRemainingStock);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbMediName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.panelMediList);
            this.Controls.Add(this.sepLine3);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblMediName);
            this.Controls.Add(this.sepLinetwo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtSrNo);
            this.Controls.Add(this.lblSrNo);
            this.Controls.Add(this.sepLineOne);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.lblShopInvoice);
            this.Name = "ShopInvoice";
            this.Size = new System.Drawing.Size(1000, 680);
            this.Load += new System.EventHandler(this.ShopInvoice_Load);
            this.panelMediList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        //private void dgvMediList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    using (SolidBrush b = new SolidBrush(dgvMediList.RowHeadersDefaultCellStyle.ForeColor))
        //    {
        //        e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
        //    }
        //}

        #endregion
        private System.Windows.Forms.Label lblShopInvoice;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblDateTime;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private Bunifu.Framework.UI.BunifuSeparator sepLineOne;
        private System.Windows.Forms.Label lblSrNo;
        private Bunifu.Framework.UI.BunifuSeparator sepLinetwo;
        private System.Windows.Forms.Label lblMediName;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblPrice;
        private Bunifu.Framework.UI.BunifuSeparator sepLine3;
        private System.Windows.Forms.Panel panelMediList;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMediList;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblBalance;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQty;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBalance;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdvance;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoice;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItems;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMediName;
        private DevComponents.Editors.ComboItem Panadol;
        private DevComponents.Editors.ComboItem Bludol;
        private DataGridViewTextBoxColumn MediName;
        private DataGridViewTextBoxColumn Batch;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn Price;
        private Label lblStock;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStock;
        private Label lblRemainingStock;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemainingStock;
    }
}
