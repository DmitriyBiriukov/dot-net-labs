using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем и настраиваем первый TextBox
            TextBox textBox1 = new TextBox();
            textBox1.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            textBox1.ForeColor = Color.Gray;
            textBox1.BackColor = Color.Red;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.AutoSize = false;
            textBox1.Width = 200;  // Устанавливаем ширину
            textBox1.Height = 50;   // Устанавливаем высоту
            textBox1.Location = new Point((this.ClientSize.Width - textBox1.Width) / 2, 50);  // Располагаем по центру

            // Создаем и настраиваем второй TextBox
            TextBox textBox2 = new TextBox();
            textBox2.Font = new Font("Arial", 17, FontStyle.Underline);
            textBox2.ForeColor = Color.Brown;
            textBox2.BackColor = Color.Purple;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.AutoSize = false;
            textBox2.Width = 200;
            textBox2.Height = 50;
            textBox2.Location = new Point((this.ClientSize.Width - textBox2.Width) / 2, 150);

            // Создаем и настраиваем третий TextBox
            TextBox textBox3 = new TextBox();
            textBox3.Font = new Font("Arial", 13, FontStyle.Bold);
            textBox3.ForeColor = Color.Pink;
            textBox3.BackColor = Color.Blue;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.AutoSize = false;
            textBox3.Width = 200;
            textBox3.Height = 50;
            textBox3.Location = new Point((this.ClientSize.Width - textBox3.Width) / 2, 250);

            // Добавляем текстовые поля на форму
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
        }
    }
}

