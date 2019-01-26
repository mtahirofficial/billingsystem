using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System.User_Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        int imageNumber = 1;
        public void SlideImages(int totalImages)
        {
            if (imageNumber == totalImages + 1)
            {
                imageNumber = 1;
            }
            picBoxSlider.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            SlideImages(6);

        }
    }
}
