using System.Globalization;

namespace Task_05
{
    public partial class Form1 : Form
    {
        private double initialPrice = 11000;
        private double checkBox1Price = 3000;
        private double checkBox2Price = 1500;
        private double checkBox3Price = 1000;
        private double checkBox4Price = 550;
        private double selectedPrice = 0;
        public Form1()
        {
            InitializeComponent();
            // ������������� �������� ������� ����� �� ����������
            CultureInfo culture = new CultureInfo("uk-UA");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            // ��������� ComboBox ��������
            comboBox1.Items.Add("������ (UAH)");
            comboBox1.Items.Add("������� (USD)");
            comboBox1.Items.Add("���� (EUR)");
            comboBox1.SelectedIndex = 0;

            // �������� ���������� ������� ��� ��������� ������
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateTotal();
        }

        private void ConvertToSelectedCurrency(double amount, out string currencySymbol, out double convertedAmount)
        {
            string selectedCurrency = comboBox1.SelectedItem.ToString();
            currencySymbol = "";

            // ������������� ����� ������ ��� ������� (�������� �� �� ���������� ������)
            double usdExchangeRate = 0.028; // 1 UAH = 0.04 USD
            double eurExchangeRate = 0.026; // 1 UAH = 0.035 EUR

            if (selectedCurrency == "������� (USD)")
            {
                currencySymbol = "USD";
                convertedAmount = amount * usdExchangeRate;
            }
            else if (selectedCurrency == "���� (EUR)")
            {
                currencySymbol = "EUR";
                convertedAmount = amount * eurExchangeRate;
            }
            else
            {
                currencySymbol = "UAH";
                convertedAmount = amount;
            }
        }

        private void UpdateTotal()
        {
            double totalInitialPrice = initialPrice;
            double totalCheckBox1Price = checkBox1Price;
            double totalCheckBox2Price = checkBox2Price;
            double totalCheckBox3Price = checkBox3Price;
            double totalCheckBox4Price = checkBox4Price;

            if (comboBox1.SelectedItem.ToString() != "������ (UAH)")
            {
                string selectedCurrencySymbol;
                double convertedInitialPrice;
                double convertedCheckBox1Price;
                double convertedCheckBox2Price;
                double convertedCheckBox3Price;
                double convertedCheckBox4Price;

                ConvertToSelectedCurrency(initialPrice, out selectedCurrencySymbol, out convertedInitialPrice);
                ConvertToSelectedCurrency(checkBox1Price, out selectedCurrencySymbol, out convertedCheckBox1Price);
                ConvertToSelectedCurrency(checkBox2Price, out selectedCurrencySymbol, out convertedCheckBox2Price);
                ConvertToSelectedCurrency(checkBox3Price, out selectedCurrencySymbol, out convertedCheckBox3Price);
                ConvertToSelectedCurrency(checkBox4Price, out selectedCurrencySymbol, out convertedCheckBox4Price);

                totalInitialPrice = convertedInitialPrice;
                totalCheckBox1Price = convertedCheckBox1Price;
                totalCheckBox2Price = convertedCheckBox2Price;
                totalCheckBox3Price = convertedCheckBox3Price;
                totalCheckBox4Price = convertedCheckBox4Price;
            }

            selectedPrice = 0;

            if (checkBox1.Checked)
                selectedPrice += totalCheckBox1Price;
            if (checkBox2.Checked)
                selectedPrice += totalCheckBox2Price;
            if (checkBox3.Checked)
                selectedPrice += totalCheckBox3Price;
            if (checkBox4.Checked)
                selectedPrice += totalCheckBox4Price;

            double totalPrice = totalInitialPrice + selectedPrice;
            double discountPrice = selectedPrice * 0.10;

            string currencySymbol;
            double convertedTotalPrice;
            ConvertToSelectedCurrency(totalPrice, out currencySymbol, out convertedTotalPrice);

            label6.Text = currencySymbol + ": " + convertedTotalPrice;
            label7.Text = currencySymbol + ": " + selectedPrice;
            label8.Text = currencySymbol + ": " + (selectedPrice * 0.10);
            label9.Text = currencySymbol + ": " + (convertedTotalPrice - (selectedPrice * 0.10));
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }
    }
}