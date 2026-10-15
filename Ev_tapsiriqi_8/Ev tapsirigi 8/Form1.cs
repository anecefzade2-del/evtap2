using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_tapsiriqi_8
{
    public partial class Form1 : Form
    {
        bool sekilSecilib = false;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            button2.Click -= button2_Click;
            button2.Click += button2_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pencere = new OpenFileDialog())
            {
                pencere.Title = "Şəkil seçin";
                pencere.Filter = "Şəkillər|*.jpg;*.jpeg;*.png;*.bmp";

                if (pencere.ShowDialog() == DialogResult.OK)
                {
                    Image sekil = Image.FromFile(pencere.FileName);
                    Image kohneSekil = pictureBox1.Image;

                    pictureBox1.Image = new Bitmap(sekil);

                    sekil.Dispose();
                    kohneSekil?.Dispose();

                    sekilSecilib = true;
                    progressBar1.Value = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(maskedTextBox2.Text) ||
                string.IsNullOrEmpty(maskedTextBox1.Text) ||
                !maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Bütün xanaları tam doldurun!");
                return;
            }

            if (sekilSecilib == false)
            {
                MessageBox.Show("Şəkil əlavə edin!");
                return;
            }

            progressBar1.Value = 100;
        }
    }
}