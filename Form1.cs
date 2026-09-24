using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double n1, n2;

            if (!double.TryParse(txtNumberOne.Text, out n1))
            {
                MessageBox.Show("birinci eded duz deyil", "xeta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtNumberTwo.Text, out n2))
            {
                MessageBox.Show("ikinci eded duz deyil", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCommand.SelectedItem == null)
            {
                MessageBox.Show("Zəhmət olmasa Command seçin!", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cmd = cmbCommand.SelectedItem?.ToString() ?? "";
            double result = 0;
            bool ok = true;

            switch (cmd)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        MessageBox.Show("0-a bolmek riyazi cehetden duzgun deyil, "Xeta",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = n1 / n2;
                    break;
                default:
                    ok = false;
                    break;
            }

            if (ok)
            {
                lblAnswer.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Text = "0";
            txtNumberTwo.Text = "0";
            cmbCommand.SelectedIndex = -1;
            lblAnswer.Text = "0";
            txtNumberOne.Focus();
        }
    }
}
