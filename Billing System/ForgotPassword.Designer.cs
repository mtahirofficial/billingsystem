namespace Billing_System
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshCaptcha = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.asd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 362);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnRefreshCaptcha);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.asd);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 310);
            this.panel2.TabIndex = 0;
            // 
            // btnRefreshCaptcha
            // 
            this.btnRefreshCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshCaptcha.FlatAppearance.BorderSize = 0;
            this.btnRefreshCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCaptcha.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefreshCaptcha.Image = global::Billing_System.Properties.Resources.icons8_synchronize_24;
            this.btnRefreshCaptcha.Location = new System.Drawing.Point(253, 173);
            this.btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            this.btnRefreshCaptcha.Size = new System.Drawing.Size(25, 25);
            this.btnRefreshCaptcha.TabIndex = 1;
            this.btnRefreshCaptcha.UseVisualStyleBackColor = false;
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.btnRefreshCaptcha_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(152, 237);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 32);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(22, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCode
            // 
            this.txtCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtCode.Location = new System.Drawing.Point(22, 204);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(256, 27);
            this.txtCode.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.Location = new System.Drawing.Point(27, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(255, 27);
            this.txtPassword.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(24, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 20);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "[type security code here]";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // asd
            // 
            this.asd.BackColor = System.Drawing.Color.Transparent;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.ForeColor = System.Drawing.Color.White;
            this.asd.Location = new System.Drawing.Point(27, 26);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(123, 20);
            this.asd.TabIndex = 0;
            this.asd.Text = "New Password:";
            this.asd.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbCaptcha);
            this.groupBox1.Location = new System.Drawing.Point(22, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.pbCaptcha.Location = new System.Drawing.Point(4, 10);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(252, 70);
            this.pbCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaptcha.TabIndex = 6;
            this.pbCaptcha.TabStop = false;
            this.pbCaptcha.Click += new System.EventHandler(this.pbCaptcha_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(584, 52);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Change Password";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel asd;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCode;
        private Bunifu.Framework.UI.BunifuCustomLabel txtDescription;
        private System.Windows.Forms.Button btnRefreshCaptcha;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}