namespace calculator2
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool isOperationPerformed = false;
        bool isResultShown = false;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed)
            textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)
                textBox1.Clear();

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
            }
            textBox1.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isOperationPerformed || isResultShown)

            {
                textBox1.Text += "";
                isOperationPerformed = false;
                isResultShown = false;
                return;
            }
            textBox1.Text += "00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || isResultShown)
            {
                textBox1.Text = "0";
                isOperationPerformed = false;
                isResultShown = false;
                return;
            }
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(operation) && !isOperationPerformed)
            {
                button14.PerformClick();
            }
            firstNumber = double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
            operation = btn.Text;
            isOperationPerformed = true;
            isResultShown = true;

            textBox2.Text = firstNumber + " " + operation;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(operation) && !isOperationPerformed)
            {
                button15.PerformClick();
            }
            firstNumber = double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
            operation = btn.Text;
            isOperationPerformed = true;
            isResultShown = true; 

            textBox2.Text = firstNumber + " " + operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(operation) && !isOperationPerformed)
            {
                button16.PerformClick();
            }
            firstNumber = double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
            operation = btn.Text;
            isOperationPerformed = true;
            isResultShown = true;

            textBox2.Text = firstNumber + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(operation) && !isOperationPerformed)
            {
                button17.PerformClick();
            }
            firstNumber = double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
            operation = btn.Text;
            isOperationPerformed = true;
            isResultShown = true;


            textBox2.Text = firstNumber + " " + operation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    
                    break;
                default:
                    return;

            }
            textBox1.Text = result.ToString();
            textBox2.Text = firstNumber + " " + operation + " " + secondNumber + " = " + result;

            firstNumber = result;

            operation = "";
            isOperationPerformed = false;
            isResultShown = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || isResultShown)
            {
                return;
            }
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            }
            else
            {
                textBox1.Text = "0";

            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            firstNumber = 0;
            operation = "";
            isOperationPerformed = false;
            isResultShown = false;
        }
    }
}
