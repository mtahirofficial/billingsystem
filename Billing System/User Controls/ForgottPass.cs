using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Billing_System.User_Controls
{
    public partial class ForgottPass : UserControl
    {
        public ForgottPass()
        {
            InitializeComponent();
        }
        private void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Green);
            //For Creating Lines on The Captcha 
            for (int i = 0; i < 20; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }

        }
        Random rand = new Random();
        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }
        string code;
        private string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();
            if (String.IsNullOrEmpty(code))
            {
                string alphabets = "abcdefghijklmnopqrstuvwxyz1234567890";
                Random r = new Random();
                for (int j = 0; j <= 5; j++)
                {
                    randomText.Append(alphabets[r.Next(alphabets.Length)]);
                }
                code = randomText.ToString();
            }
            return code;
        }
        private void CreateImage()
        {
            string code = GetRandomText();
            Bitmap bitmap = new Bitmap(200, 50, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 50);
            SolidBrush b = new SolidBrush(Color.Black);
            SolidBrush White = new SolidBrush(Color.White);
            int counter = 0;
            g.DrawRectangle(pen, rect);
            g.FillRectangle(b, rect);
            for (int i = 0; i < code.Length; i++)
            {
                g.DrawString(code[i].ToString(), new Font("Georgia", 10 + rand.Next(14, 18)), White, new PointF(10 + counter, 10));
                counter += 20;
            }
            DrawRandomLines(g);
            if (File.Exists("e:/tempimage.bmp"))
            {
                try
                {
                    File.Delete("e:/tempimage.bmp");
                    bitmap.Save("e:/tempimage.bmp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                bitmap.Save("e:/tempimage.bmp");
            }
            g.Dispose();
            bitmap.Dispose();
            pbCaptcha.Image = Image.FromFile("e:/tempimage.bmp");
        }

        private void ForgottPass_Load(object sender, EventArgs e)
        {
            if (pbCaptcha.Image != null)
            {
                pbCaptcha.Image.Dispose();
                code = "";
            }
            
            CreateImage();
        }

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            pbCaptcha.Image.Dispose();
            code = "";
            CreateImage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //pbCaptcha.Image.Dispose();
            //code = "";
            txtCode.Clear();
            txtPassword.Clear();
        }

        private void asd_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            txtCode.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == code.ToString())
            {
                MessageBox.Show("Proceed");
                //Close();
            }
            else
            {
                MessageBox.Show("Incorrect entry");
            }
        }
    }

    
}
