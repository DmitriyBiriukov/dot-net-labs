using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03_1_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(double perimeter, double area) : this()
        {
            // Отображаем переданные данные на метках
            label4.Text = $"Периметр: {perimeter}";
            label5.Text = $"Площадь: {area}";
        }
    }
}
