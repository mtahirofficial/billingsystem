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
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        //Keep pdf file locations
        List<string> pdfFiles = new List<string>();

        // Browse pdf and get their paths
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pdfFiles = new List<string>();
                foreach (string fileName in openFileDialog.FileNames)
                    pdfFiles.Add(fileName);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string installedPath = Application.StartupPath + "pdf";

            //Check whether folder path is exist
            if (!System.IO.Directory.Exists(installedPath))
            {
                // If not create new folder
                System.IO.Directory.CreateDirectory(installedPath);
            }
            //Save pdf files in installedPath
            foreach (string sourceFileName in pdfFiles)
            {
                string destinationFileName = System.IO.Path.Combine(installedPath, System.IO.Path.GetFileName(sourceFileName));
                System.IO.File.Copy(sourceFileName, destinationFileName);
            }
        }
    }
}
