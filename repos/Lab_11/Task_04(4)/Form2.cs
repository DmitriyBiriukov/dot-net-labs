using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03_1_
{
    public partial class Form2 : Form
    {
        public double Result { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        public double GetResult()
        {
            return Result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Выполните вычисления
            // Предположим, что textBox1, textBox2, textBox3 содержат ваши данные
            double x, y, z;

            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && double.TryParse(textBox3.Text, out z))
            {
                // Вычисляем результат
                double result = 1.0;

                for (int i = 1; i <= y; i++)
                {
                    double numerator = i + z;
                    double denominator = x - y + Math.Pow(i, 2);

                    if (denominator == 0)
                    {
                        MessageBox.Show("Ошибка: Знаменатель равен нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    result *= Math.Sqrt(numerator / denominator);
                }

                // Присваиваем результат свойству формы
                Result = result;

                // Закрываем Form2 с результатом
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
