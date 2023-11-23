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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            selectedPrice = 0;

            if (checkBox1.Checked)
                selectedPrice += checkBox1Price;
            if (checkBox2.Checked)
                selectedPrice += checkBox2Price;
            if (checkBox3.Checked)
                selectedPrice += checkBox3Price;
            if (checkBox4.Checked)
                selectedPrice += checkBox4Price;

            label6.Text = (initialPrice + selectedPrice).ToString("C0"); // "C0" ����������� ������ � ������
            label7.Text = selectedPrice.ToString("C0"); // "C0" ����������� ������ � ������
            label8.Text = (selectedPrice * 0.10).ToString("C0"); // "C0" ����������� ������ � ������
            label9.Text = ((initialPrice + selectedPrice) - (selectedPrice * 0.10)).ToString("C0");
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
    }
}