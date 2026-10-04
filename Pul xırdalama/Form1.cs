using System;
using System.Drawing;
using System.Windows.Forms;

namespace pulxırdalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılarkən bütün əskinasları və label-ləri gizlədirik
            SifirlaUI();
        }

        // Bütün elementləri ilkin (deaktiv/gizli) vəziyyətə gətirən metod
        private void SifirlaUI()
        {
            pb500.Visible = false;
            pb200.Visible = false;
            pb100.Visible = false;
            pb50.Visible = false;
            pb20.Visible = false;
            pb10.Visible = false;
            pb5.Visible = false;
            pb1.Visible = false;

            lbl500.Visible = false;
            lbl200.Visible = false;
            lbl100.Visible = false;
            lbl50.Visible = false;
            lbl20.Visible = false;
            lbl10.Visible = false;
            lbl5.Visible = false;
            lbl1.Visible = false;

            lbl500.Text = "";
            lbl200.Text = "";
            lbl100.Text = "";
            lbl50.Text = "";
            lbl20.Text = "";
            lbl10.Text = "";
            lbl5.Text = "";
            lbl1.Text = "";
        }

        private void btnXirdala_Click(object sender, EventArgs e)
        {
            // 1. ErrorProvider Yoxlanışı: Xana boşdursa xəbərdarlıq edirik
            if (string.IsNullOrWhiteSpace(txtMebleg.Text))
            {
                errorProvider1.SetError(txtMebleg, "Məbləğ daxil edin");
                return;
            }
            else
            {
                // Məbləğ daxil edildikdə errorProvider işini yekunlaşdırır
                errorProvider1.SetError(txtMebleg, "");
            }

            // 2. Məbləğin ədəd olmasının yoxlanılması
            int mebleg;
            bool ugurludur = int.TryParse(txtMebleg.Text, out mebleg);

            if (!ugurludur)
            {
                MessageBox.Show("Lütfən düzgün tam ədəd daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Mənfi və sıfır məbləğ yoxlanışı
            if (mebleg <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hər yeni xırdalama zamanı əvvəlki nəticələri təmizləyirik
            SifirlaUI();

            // 4. Əskinasların xırdalanması alqoritmi
            int say500 = mebleg / 500;
            mebleg %= 500;

            int say200 = mebleg / 200;
            mebleg %= 200;

            int say100 = mebleg / 100;
            mebleg %= 100;

            int say50 = mebleg / 50;
            mebleg %= 50;

            int say20 = mebleg / 20;
            mebleg %= 20;

            int say10 = mebleg / 10;
            mebleg %= 10;

            int say5 = mebleg / 5;
            mebleg %= 5;

            int say1 = mebleg;

            // 5. Yalnız istifadə olunan əskinasları görünən və aktiv edirik
            if (say500 > 0)
            {
                pb500.Visible = true;
                lbl500.Visible = true;
                lbl500.Text = say500 + " ədəd";
            }

            if (say200 > 0)
            {
                pb200.Visible = true;
                lbl200.Visible = true;
                lbl200.Text = say200 + " ədəd";
            }

            if (say100 > 0)
            {
                pb100.Visible = true;
                lbl100.Visible = true;
                lbl100.Text = say100 + " ədəd";
            }

            if (say50 > 0)
            {
                pb50.Visible = true;
                lbl50.Visible = true;
                lbl50.Text = say50 + " ədəd";
            }

            if (say20 > 0)
            {
                pb20.Visible = true;
                lbl20.Visible = true;
                lbl20.Text = say20 + " ədəd";
            }

            if (say10 > 0)
            {
                pb10.Visible = true;
                lbl10.Visible = true;
                lbl10.Text = say10 + " ədəd";
            }

            if (say5 > 0)
            {
                pb5.Visible = true;
                lbl5.Visible = true;
                lbl5.Text = say5 + " ədəd";
            }

            if (say1 > 0)
            {
                pb1.Visible = true;
                lbl1.Visible = true;
                lbl1.Text = say1 + " ədəd";
            }
        }

        private void txtMebleg_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMebleg.Text))
            {
                errorProvider1.SetError(txtMebleg, "");
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}