using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers(); // Ініціалізація обробників подій
        }

        private void InitializeEventHandlers()
        {
            // Прив'язка обробників подій до кнопок
            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                label1.Text = "Ви натиснули на " + clickedButton.Text;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Опціонально: налаштування вигляду Label
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
        }
    }
}
