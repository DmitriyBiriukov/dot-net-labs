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
            if (double.TryParse(textBox1.Text, NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-US"), out double inputValue))
            {
                // ���������� ����� ����������� ������ � ����� ���������� � label3.
                // ��������:
                double convertedValue = inputValue * 0.047; // ������ ����������� � ������.
                label3.Text = $"{convertedValue} AZN";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // ���������, �������� �� ����� � textBox1 ������ � ��������� ������ � �������� ���� �� ���� �����
            if (double.TryParse(textBox1.Text, NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-US"), out double inputValue) &&
                textBox1.Text.Any(char.IsDigit))
            {
                // ���� ����� �������� ������ � �������� ���� �� ���� �����, �� ������ �������� ������������
                button1.Enabled = true;
            }
            else
            {
                // ���� ����� �� �������� ������ ��� �� �������� ����, �� ������ �������� �� ������������
                button1.Enabled = false;
            }
        }
    }
}
