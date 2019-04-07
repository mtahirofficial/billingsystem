namespace Billing_System.User_Controls
{
    partial class NewMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.lblHeading = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblMediName = new System.Windows.Forms.Label();
            this.txtRate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtQty = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMediName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.gbNewMedicine = new System.Windows.Forms.GroupBox();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.lblNewMedi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMediList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.gbNewMedicine.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageHeading
            // 
            this.lblPageHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPageHeading.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeading.Location = new System.Drawing.Point(500, 0);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(228, 35);
            this.lblPageHeading.TabIndex = 19;
            this.lblPageHeading.Text = "Add New Medicine";
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
            this.lblHeading.TabIndex = 20;
            this.lblHeading.TabStop = false;
            this.lblHeading.Text = "<b><font size=\"+6\">Zahid<font color=\"#69C9E9\"> Medical Store</font></font></b>";
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(6, 343);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(141, 28);
            this.lblRate.TabIndex = 29;
            this.lblRate.Text = "Rate :";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 276);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(141, 28);
            this.lblQty.TabIndex = 27;
            this.lblQty.Text = "Quantity :";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBatch
            // 
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(6, 209);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(141, 28);
            this.lblBatch.TabIndex = 25;
            this.lblBatch.Text = "Batch Name :";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMediName
            // 
            this.lblMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediName.Location = new System.Drawing.Point(6, 142);
            this.lblMediName.Name = "lblMediName";
            this.lblMediName.Size = new System.Drawing.Size(141, 28);
            this.lblMediName.TabIndex = 23;
            this.lblMediName.Text = "Medicine Name :";
            this.lblMediName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtRate.Location = new System.Drawing.Point(10, 374);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.PreventEnterBeep = true;
            this.txtRate.Size = new System.Drawing.Size(261, 33);
            this.txtRate.TabIndex = 30;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
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
            this.txtQty.Location = new System.Drawing.Point(10, 307);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.PreventEnterBeep = true;
            this.txtQty.Size = new System.Drawing.Size(261, 33);
            this.txtQty.TabIndex = 28;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
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
            this.txtBatch.Location = new System.Drawing.Point(10, 240);
            this.txtBatch.MaxLength = 10;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.PreventEnterBeep = true;
            this.txtBatch.Size = new System.Drawing.Size(261, 33);
            this.txtBatch.TabIndex = 26;
            this.txtBatch.TextChanged += new System.EventHandler(this.txtBatch_TextChanged);
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
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
            this.txtMediName.Location = new System.Drawing.Point(10, 173);
            this.txtMediName.MaxLength = 32;
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PreventEnterBeep = true;
            this.txtMediName.Size = new System.Drawing.Size(261, 33);
            this.txtMediName.TabIndex = 24;
            this.txtMediName.TextChanged += new System.EventHandler(this.txtMediName_TextChanged);
            this.txtMediName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMediName_KeyDown);
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
            this.txtSrNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.ForeColor = System.Drawing.Color.Black;
            this.txtSrNo.Location = new System.Drawing.Point(10, 106);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.PreventEnterBeep = true;
            this.txtSrNo.ReadOnly = true;
            this.txtSrNo.Size = new System.Drawing.Size(261, 33);
            this.txtSrNo.TabIndex = 21;
            this.txtSrNo.TabStop = false;
            this.txtSrNo.Text = "1";
            this.txtSrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSrNo
            // 
            this.lblSrNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrNo.Location = new System.Drawing.Point(6, 74);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(141, 28);
            this.lblSrNo.TabIndex = 22;
            this.lblSrNo.Text = "Sr # :";
            this.lblSrNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbNewMedicine
            // 
            this.gbNewMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNewMedicine.Controls.Add(this.btnAdd);
            this.gbNewMedicine.Controls.Add(this.lblNewMedi);
            this.gbNewMedicine.Controls.Add(this.lblSrNo);
            this.gbNewMedicine.Controls.Add(this.lblMediName);
            this.gbNewMedicine.Controls.Add(this.lblRate);
            this.gbNewMedicine.Controls.Add(this.txtRate);
            this.gbNewMedicine.Controls.Add(this.lblBatch);
            this.gbNewMedicine.Controls.Add(this.txtQty);
            this.gbNewMedicine.Controls.Add(this.lblQty);
            this.gbNewMedicine.Controls.Add(this.txtBatch);
            this.gbNewMedicine.Controls.Add(this.txtSrNo);
            this.gbNewMedicine.Controls.Add(this.txtMediName);
            this.gbNewMedicine.Location = new System.Drawing.Point(10, 96);
            this.gbNewMedicine.Name = "gbNewMedicine";
            this.gbNewMedicine.Size = new System.Drawing.Size(282, 455);
            this.gbNewMedicine.TabIndex = 33;
            this.gbNewMedicine.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(261, 36);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNewMedi
            // 
            this.lblNewMedi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewMedi.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMedi.Location = new System.Drawing.Point(18, 16);
            this.lblNewMedi.Name = "lblNewMedi";
            this.lblNewMedi.Size = new System.Drawing.Size(247, 35);
            this.lblNewMedi.TabIndex = 33;
            this.lblNewMedi.Text = "Enter New Medicine";
            this.lblNewMedi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvMediList);
            this.panel1.Location = new System.Drawing.Point(298, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 445);
            this.panel1.TabIndex = 34;
            // 
            // dgvMediList
            // 
            this.dgvMediList.AllowUserToAddRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMediList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMediList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMediList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMediList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMediList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMediList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMediList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMediList.Location = new System.Drawing.Point(0, 0);
            this.dgvMediList.MultiSelect = false;
            this.dgvMediList.Name = "dgvMediList";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMediList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMediList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMediList.Size = new System.Drawing.Size(699, 445);
            this.dgvMediList.TabIndex = 21;
            this.dgvMediList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMediList_DataBindingComplete);
            this.dgvMediList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMediList_RowPostPaint);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(860, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 36);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(720, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 36);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbNewMedicine);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblPageHeading);
            this.Name = "NewMedicine";
            this.Size = new System.Drawing.Size(1000, 554);
            this.Load += new System.EventHandler(this.NewMedicine_Load);
            this.gbNewMedicine.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPageHeading;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblHeading;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblMediName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQty;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMediName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrNo;
        private System.Windows.Forms.Label lblSrNo;
        private System.Windows.Forms.GroupBox gbNewMedicine;
        private System.Windows.Forms.Label lblNewMedi;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMediList;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}
