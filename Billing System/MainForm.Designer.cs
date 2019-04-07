namespace Billing_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblDeveloperLink = new System.Windows.Forms.LinkLabel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMedicineStock = new System.Windows.Forms.LinkLabel();
            this.lblNewMedicine = new System.Windows.Forms.LinkLabel();
            this.lblSignout = new System.Windows.Forms.LinkLabel();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.lblViewInvoice = new System.Windows.Forms.LinkLabel();
            this.lblInvoice = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.home1 = new Billing_System.User_Controls.Home();
            this.login1 = new Billing_System.User_Controls.Login();
            this.newMedicine1 = new Billing_System.User_Controls.NewMedicine();
            this.shopInvoice1 = new Billing_System.User_Controls.ShopInvoice();
            this.viewInvioces1 = new Billing_System.User_Controls.ViewInvioces();
            this.viewStock1 = new Billing_System.User_Controls.ViewStock();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Snow;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.lblDeveloperLink);
            this.bunifuGradientPanel1.Controls.Add(this.labelX2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.labelX1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 638);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1000, 27);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // lblDeveloperLink
            // 
            this.lblDeveloperLink.BackColor = System.Drawing.Color.Transparent;
            this.lblDeveloperLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDeveloperLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloperLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeveloperLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblDeveloperLink.LinkColor = System.Drawing.Color.Blue;
            this.lblDeveloperLink.Location = new System.Drawing.Point(891, 0);
            this.lblDeveloperLink.Name = "lblDeveloperLink";
            this.lblDeveloperLink.Size = new System.Drawing.Size(107, 25);
            this.lblDeveloperLink.TabIndex = 7;
            this.lblDeveloperLink.TabStop = true;
            this.lblDeveloperLink.Text = "Fm devndesign";
            this.lblDeveloperLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDeveloperLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDeveloperLink_LinkClicked);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(806, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(79, 24);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Developed By :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(25, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(188, 24);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Zahid Medicine Company | 2018";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lblMedicineStock);
            this.bunifuGradientPanel2.Controls.Add(this.lblNewMedicine);
            this.bunifuGradientPanel2.Controls.Add(this.lblSignout);
            this.bunifuGradientPanel2.Controls.Add(this.lblLogin);
            this.bunifuGradientPanel2.Controls.Add(this.lblViewInvoice);
            this.bunifuGradientPanel2.Controls.Add(this.lblInvoice);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1000, 61);
            this.bunifuGradientPanel2.TabIndex = 5;
            // 
            // lblMedicineStock
            // 
            this.lblMedicineStock.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lblMedicineStock.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicineStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMedicineStock.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineStock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblMedicineStock.LinkColor = System.Drawing.Color.White;
            this.lblMedicineStock.Location = new System.Drawing.Point(370, 0);
            this.lblMedicineStock.Name = "lblMedicineStock";
            this.lblMedicineStock.Size = new System.Drawing.Size(141, 61);
            this.lblMedicineStock.TabIndex = 47;
            this.lblMedicineStock.TabStop = true;
            this.lblMedicineStock.Text = "View All Stock";
            this.lblMedicineStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMedicineStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblNewMedicine
            // 
            this.lblNewMedicine.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lblNewMedicine.BackColor = System.Drawing.Color.Transparent;
            this.lblNewMedicine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNewMedicine.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMedicine.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblNewMedicine.LinkColor = System.Drawing.Color.White;
            this.lblNewMedicine.Location = new System.Drawing.Point(218, 0);
            this.lblNewMedicine.Name = "lblNewMedicine";
            this.lblNewMedicine.Size = new System.Drawing.Size(152, 61);
            this.lblNewMedicine.TabIndex = 46;
            this.lblNewMedicine.TabStop = true;
            this.lblNewMedicine.Text = "Add Medicines";
            this.lblNewMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewMedicine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblSignout
            // 
            this.lblSignout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lblSignout.BackColor = System.Drawing.Color.Transparent;
            this.lblSignout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSignout.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblSignout.LinkColor = System.Drawing.Color.White;
            this.lblSignout.Location = new System.Drawing.Point(830, 0);
            this.lblSignout.Name = "lblSignout";
            this.lblSignout.Size = new System.Drawing.Size(85, 61);
            this.lblSignout.TabIndex = 20;
            this.lblSignout.TabStop = true;
            this.lblSignout.Text = "Signout";
            this.lblSignout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignout_LinkClicked);
            // 
            // lblLogin
            // 
            this.lblLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLogin.LinkColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(915, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 61);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogin_LinkClicked);
            // 
            // lblViewInvoice
            // 
            this.lblViewInvoice.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lblViewInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lblViewInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblViewInvoice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInvoice.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblViewInvoice.LinkColor = System.Drawing.Color.White;
            this.lblViewInvoice.Location = new System.Drawing.Point(85, 0);
            this.lblViewInvoice.Name = "lblViewInvoice";
            this.lblViewInvoice.Size = new System.Drawing.Size(133, 61);
            this.lblViewInvoice.TabIndex = 30;
            this.lblViewInvoice.TabStop = true;
            this.lblViewInvoice.Text = "View Invoice";
            this.lblViewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewInvoice_LinkClicked);
            // 
            // lblInvoice
            // 
            this.lblInvoice.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lblInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInvoice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblInvoice.LinkColor = System.Drawing.Color.White;
            this.lblInvoice.Location = new System.Drawing.Point(0, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(85, 61);
            this.lblInvoice.TabIndex = 25;
            this.lblInvoice.TabStop = true;
            this.lblInvoice.Text = "Invoice";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInvoice_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // controlPanel
            // 
            this.controlPanel.AutoScroll = true;
            this.controlPanel.Controls.Add(this.home1);
            this.controlPanel.Controls.Add(this.login1);
            this.controlPanel.Controls.Add(this.newMedicine1);
            this.controlPanel.Controls.Add(this.shopInvoice1);
            this.controlPanel.Controls.Add(this.viewInvioces1);
            this.controlPanel.Controls.Add(this.viewStock1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 61);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1000, 577);
            this.controlPanel.TabIndex = 20;
            // 
            // home1
            // 
            this.home1.AutoScroll = true;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1000, 577);
            this.home1.TabIndex = 7;
            // 
            // login1
            // 
            this.login1.AutoScroll = true;
            this.login1.BackColor = System.Drawing.Color.White;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1000, 577);
            this.login1.TabIndex = 5;
            // 
            // newMedicine1
            // 
            this.newMedicine1.AutoScroll = true;
            this.newMedicine1.BackColor = System.Drawing.Color.White;
            this.newMedicine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMedicine1.Location = new System.Drawing.Point(0, 0);
            this.newMedicine1.Name = "newMedicine1";
            this.newMedicine1.Size = new System.Drawing.Size(1000, 577);
            this.newMedicine1.TabIndex = 4;
            // 
            // shopInvoice1
            // 
            this.shopInvoice1.AutoScroll = true;
            this.shopInvoice1.BackColor = System.Drawing.Color.White;
            this.shopInvoice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopInvoice1.Location = new System.Drawing.Point(0, 0);
            this.shopInvoice1.Name = "shopInvoice1";
            this.shopInvoice1.Size = new System.Drawing.Size(1000, 577);
            this.shopInvoice1.TabIndex = 3;
            // 
            // viewInvioces1
            // 
            this.viewInvioces1.AutoScroll = true;
            this.viewInvioces1.BackColor = System.Drawing.Color.White;
            this.viewInvioces1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewInvioces1.Location = new System.Drawing.Point(0, 0);
            this.viewInvioces1.Name = "viewInvioces1";
            this.viewInvioces1.Size = new System.Drawing.Size(1000, 577);
            this.viewInvioces1.TabIndex = 1;
            // 
            // viewStock1
            // 
            this.viewStock1.AutoScroll = true;
            this.viewStock1.BackColor = System.Drawing.Color.White;
            this.viewStock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewStock1.Location = new System.Drawing.Point(0, 0);
            this.viewStock1.Name = "viewStock1";
            this.viewStock1.Size = new System.Drawing.Size(1000, 577);
            this.viewStock1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 665);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(825, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahid Medicine Company";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblDeveloperLink;
        private DevComponents.DotNetBar.LabelX labelX2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.LinkLabel lblInvoice;
        private System.Windows.Forms.LinkLabel lblViewInvoice;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.LinkLabel lblSignout;
        private System.Windows.Forms.LinkLabel lblMedicineStock;
        private System.Windows.Forms.LinkLabel lblNewMedicine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel controlPanel;
        private User_Controls.Home home1;
        private User_Controls.Login login1;
        private User_Controls.NewMedicine newMedicine1;
        private User_Controls.ShopInvoice shopInvoice1;
        private User_Controls.ViewInvioces viewInvioces1;
        private User_Controls.ViewStock viewStock1;
    }
}