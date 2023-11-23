using System;
using System.Windows.Forms;

namespace Task_14
{
    public partial class Form1 : Form
    {
        private bool dialogShown = false;

        public Form1()
        {
            InitializeComponent();
            // Додаємо обробник події Load до форми
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!dialogShown)
            {
                dialogShown = true;

                // Виводимо діалогове вікно з запитом
                DialogResult result = MessageBox.Show("Завантажити форму проекту?", "Запит", MessageBoxButtons.YesNo);

                // Перевіряємо результат діалогового вікна
                if (result == DialogResult.Yes)
                {
                    // Якщо користувач обрав "ТАК", то завантажуємо форму
                    // Задайте розмір і розташування форми (наприклад, верхню половину екрану)
                    this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 2);
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new System.Drawing.Point(0, 0);

                    // Додайте код для завантаження форми проекту тут
                }
                else
                {
                    // Якщо користувач обрав "НІ", то не завантажуємо форму
                    this.Close();
                }
            }

            // Видаляємо обробник події Load
            this.Load -= Form1_Load;
        }
    }
}
