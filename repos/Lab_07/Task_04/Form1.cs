using System;
using System.Windows.Forms;

namespace Task_04
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
            label1.DoubleClick += Label_DoubleClick;
            label2.DoubleClick += Label_DoubleClick;
            label3.DoubleClick += Label_DoubleClick;
        }

        private void Label_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // Отримуємо поточний розмір шрифта
                float currentFontSize = clickedLabel.Font.Size;

                // Зменшуємо розмір шрифта на 1 pt
                float newFontSize = currentFontSize - 1;

                // Мінімальний розмір шрифта, якщо він менший 1 pt
                if (newFontSize < 1)
                {
                    newFontSize = 1;
                }

                // Створюємо новий об'єкт шрифта з оновленим розміром
                Font newFont = new Font(clickedLabel.Font.FontFamily, newFontSize);

                // Встановлюємо новий шрифт для Label
                clickedLabel.Font = newFont;
            }
        }
    }
}