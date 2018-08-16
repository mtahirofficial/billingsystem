namespace Billing_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recPassChange = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recLogout = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.BtnCompany = new System.Windows.Forms.Button();
            this.BtnStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recPassChange,
            this.recLogout});
            this.shapeContainer1.Size = new System.Drawing.Size(913, 450);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // recPassChange
            // 
            this.recPassChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recPassChange.CornerRadius = 5;
            this.recPassChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recPassChange.Location = new System.Drawing.Point(680, 404);
            this.recPassChange.Name = "recPassChange";
            this.recPassChange.Size = new System.Drawing.Size(105, 36);
            // 
            // recLogout
            // 
            this.recLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recLogout.BackgroundImage")));
            this.recLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recLogout.CornerRadius = 5;
            this.recLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recLogout.Location = new System.Drawing.Point(796, 404);
            this.recLogout.Name = "recLogout";
            this.recLogout.Size = new System.Drawing.Size(105, 36);
            this.recLogout.Click += new System.EventHandler(this.recLogout_Click);
            // 
            // BtnCompany
            // 
            this.BtnCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.BtnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCompany.FlatAppearance.BorderSize = 0;
            this.BtnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompany.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnCompany.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompany.Image")));
            this.BtnCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCompany.Location = new System.Drawing.Point(746, 40);
            this.BtnCompany.Name = "BtnCompany";
            this.BtnCompany.Size = new System.Drawing.Size(131, 103);
            this.BtnCompany.TabIndex = 1;
            this.BtnCompany.Text = "Zahid Medicine Company";
            this.BtnCompany.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCompany.UseVisualStyleBackColor = false;
            this.BtnCompany.Click += new System.EventHandler(this.BtnCompany_Click);
            // 
            // BtnStore
            // 
            this.BtnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.BtnStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnStore.FlatAppearance.BorderSize = 0;
            this.BtnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStore.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStore.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnStore.Image = ((System.Drawing.Image)(resources.GetObject("BtnStore.Image")));
            this.BtnStore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnStore.Location = new System.Drawing.Point(43, 40);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Size = new System.Drawing.Size(131, 103);
            this.BtnStore.TabIndex = 0;
            this.BtnStore.Text = "Zahid Medical Store";
            this.BtnStore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStore.UseVisualStyleBackColor = false;
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.BtnStore);
            this.Controls.Add(this.BtnCompany);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahid Medicine Company";
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recLogout;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recPassChange;
        private System.Windows.Forms.Button BtnCompany;
        private System.Windows.Forms.Button BtnStore;
    }
}