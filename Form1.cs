using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double height;
            double weight;

            if (!double.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("Boyu düzgün daxil edin!");
                return;
            }

            if (!double.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Çəkini düzgün daxil edin!");
                return;
            }

            if (height <= 0 || weight <= 0)
            {
                MessageBox.Show("Boy və çəki 0-dan böyük olmalıdır!");
                return;
            }

            
            height = height / 100;

            
            double bki = weight / (height * height);

            if (bki < 18.5)
            {
                lblResult.Text =
                    "BKI: " + bki.ToString("0.00") +
                    "\n\nNəticə: ARIQ";

                ShowImage("ariq.jpg");
            }
            else if (bki < 25)
            {
                lblResult.Text =
                    "BKI: " + bki.ToString("0.00") +
                    "\n\nNəticə: NORMAL";

                ShowImage("normal.jpg");
            }
            else if (bki < 30)
            {
                lblResult.Text =
                    "BKI: " + bki.ToString("0.00") +
                    "\n\nNəticə: ARTİQ ÇƏKİLİ";

                ShowImage("fat.jpg");
            }
            else
            {
                lblResult.Text =
                    "BKI: " + bki.ToString("0.00") +
                    "\n\nNəticə: OBEZ";

                ShowImage("obese.jpg");
            }
        }

        private void ShowImage(string imageName)
        {
            string path = Path.Combine(
                Application.StartupPath,
                "Images",
                imageName);

            if (File.Exists(path))
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show(
                    "Şəkil tapılmadı:\n" + path);
            }
        }
    }
}
