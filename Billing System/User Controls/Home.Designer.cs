namespace Billing_System.User_Controls
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.picBoxSlider = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSlider
            // 
            this.picBoxSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxSlider.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSlider.Image")));
            this.picBoxSlider.Location = new System.Drawing.Point(0, 0);
            this.picBoxSlider.Name = "picBoxSlider";
            this.picBoxSlider.Size = new System.Drawing.Size(1000, 554);
            this.picBoxSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSlider.TabIndex = 0;
            this.picBoxSlider.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.picBoxSlider);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1000, 554);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSlider;
        private System.Windows.Forms.Timer timer;
    }
}
