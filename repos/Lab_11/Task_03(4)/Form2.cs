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
        public double Perimeter { get; private set; }
        public double Area { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        public double GetPerimeter()
        {
            return Perimeter;
        }

        public double GetArea()
        {
            return Area;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Выполните вычисления
            // Предположим, что textBox1, textBox2, textBox3 содержат ваши данные
            double side1, side2, side3;

            if (double.TryParse(textBox1.Text, out side1) && double.TryParse(textBox2.Text, out side2) && double.TryParse(textBox3.Text, out side3))
            {
                // Проверка на возможность построения треугольника
                if (IsTriangleValid(side1, side2, side3))
                {
                    // Вычисляем периметр
                    double perimeter = side1 + side2 + side3;

                    // Вычисляем площадь по формуле Герона
                    double s = perimeter / 2;
                    double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

                    // Присваиваем результаты свойствам формы
                    Perimeter = perimeter;
                    Area = area;

                    // Закрываем Form2 с результатами
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Треугольник с такими сторонами не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Проверка на возможность построения треугольника
        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
