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
                // Выполняйте здесь конвертацию валюты и вывод результата в label3.
                // Например:
                double convertedValue = inputValue * 0.047; // Пример конвертации в манаты.
                label3.Text = $"{convertedValue} AZN";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Проверяем, является ли текст в textBox1 числом с плавающей точкой и содержит хотя бы одну цифру
            if (double.TryParse(textBox1.Text, NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-US"), out double inputValue) &&
                textBox1.Text.Any(char.IsDigit))
            {
                // Если текст является числом и содержит хотя бы одну цифру, то кнопка делается кликабельной
                button1.Enabled = true;
            }
            else
            {
                // Если текст не является числом или не содержит цифр, то кнопка делается не кликабельной
                button1.Enabled = false;
            }
        }
    }
}
