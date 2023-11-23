using System;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            // Визначаємо, яка саме кнопка була натиснута, використовуючи параметр sender
            ToolStripButton button = (ToolStripButton)sender;

            // Отримуємо текст підказки для натиснутої кнопки
            string tooltipText = button.ToolTipText;

            // Виводимо текст підказки в діалоговому вікні
            MessageBox.Show(tooltipText, "Підказка");
        }
    }
}
