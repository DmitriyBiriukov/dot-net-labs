using System;
using System.Windows.Forms; // Убедитесь, что это пространство имен подключено

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            // Прив'язка одного обробника подій для всіх рядків тексту
            label1.MouseDown += Label_MouseDown;
            label1.MouseUp += Label_MouseUp;
            label2.MouseDown += Label_MouseDown;
            label2.MouseUp += Label_MouseUp;
            label3.MouseDown += Label_MouseDown;
            label3.MouseUp += Label_MouseUp;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це натискання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Змінюємо вигляд рядка тексту при натисканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Bold);
                    clickedLabel.ForeColor = Color.Red;
                }
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це відпускання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Повертаємо вигляд рядка тексту до початкового стану при відпусканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Regular);
                    clickedLabel.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}