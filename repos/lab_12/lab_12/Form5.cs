// Form5.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form5 : Form
    {
        private Form4 parentForm;

        public Form5(Form4 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность полей
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                // Отправка сообщения и сохранение в файл
                string message = $"{textBox1.Text}: {textBox2.Text} - {textBox3.Text}";
                SaveMessage(message);

                MessageBox.Show("Сообщение отправлено!");

                // Переход на Form4
                Form4 form4 = new Form4(textBox1.Text, textBox2.Text, textBox3.Text);
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }


        private void SaveMessage(string message)
        {
            // Сохранение сообщения в файле (пример использования, лучше использовать базу данных)
            string messagesFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\messages.txt"; // Путь к файлу с сообщениями (замените на свой путь)

            using (StreamWriter writer = File.AppendText(messagesFilePath))
            {
                writer.WriteLine(message);
            }
        }
    }
}
