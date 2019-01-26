namespace Billing_System.User_Controls
{
    partial class Signup
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.btnUpload = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.lblLogin.Location = new System.Drawing.Point(410, 27);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(181, 63);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Signup";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(242, 263);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(516, 28);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextColor = System.Drawing.Color.White;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.btnUpload.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(242, 297);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(516, 28);
            this.btnUpload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextColor = System.Drawing.Color.White;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblLogin);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(1000, 554);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private DevComponents.DotNetBar.ButtonX btnBrowse;
        private DevComponents.DotNetBar.ButtonX btnUpload;
    }
}
