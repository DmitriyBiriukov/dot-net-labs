using System;
using System.Globalization;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                label3.Text = "ќшибка: ¬ведите значение только в одно поле.";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double amount))
                {
                    double convertedAmount = ConvertToManat(amount);
                    label3.Text = $" ЋьЇ :{convertedAmount}";
                }
                else
                {
                    label3.Text = "ќшибка: ¬ведите допустимое число в TextBox1.";
                }
            }
            else if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (double.TryParse(textBox2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double amount))
                {
                    double convertedAmount = ConvertToHryvnia(amount);
                    label3.Text = $"  м :{convertedAmount}";
                }
                else
                {
                    label3.Text = "ќшибка: ¬ведите допустимое число в TextBox2.";
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            bool textBox1HasValue = !string.IsNullOrEmpty(textBox1.Text);
            bool textBox2HasValue = !string.IsNullOrEmpty(textBox2.Text);

            if (textBox1HasValue || textBox2HasValue)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }



        private double ConvertToManat(double amount)
        {
            double exchangeRateManat = 0.17998560115191;
            return amount * exchangeRateManat;
        }

        private double ConvertToHryvnia(double amount)
        {
            double exchangeRateHryvnia = 5.556;
            return amount * exchangeRateHryvnia;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
