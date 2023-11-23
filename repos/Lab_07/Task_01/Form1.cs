using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ви натиснули на першу кнопку";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Ви натиснули на другу кнопку";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ви натиснули на третю кнопку";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Опціонально: налаштування вигляду Label
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
        }
    }
}
