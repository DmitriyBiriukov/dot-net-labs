// Form6.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form6 : Form
    {
        private Form4 parentForm;

        public Form6(Form4 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            // Отображение полученных сообщений в listBox1
            DisplayMessages();
        }

        private void DisplayMessages()
        {
            // Очищаем listBox1 перед отображением новых сообщений
            listBox1.Items.Clear();

            // Путь к файлу с сообщениями (замените на свой путь)
            string messagesFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\messages.txt";

            if (File.Exists(messagesFilePath))
            {
                string[] lines = File.ReadAllLines(messagesFilePath);
                int messageNumber = 1;

                foreach (string line in lines)
                {
                    listBox1.Items.Add($"Сообщение {messageNumber++}: {line}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отображение полного текста выбранного сообщения в label1
            if (listBox1.SelectedIndex != -1)
            {
                string selectedMessage = listBox1.SelectedItem.ToString();
                int colonIndex = selectedMessage.IndexOf(':');
                if (colonIndex != -1 && colonIndex + 1 < selectedMessage.Length)
                {
                    string messageText = selectedMessage.Substring(colonIndex + 1).Trim();
                    label1.Text = messageText; // Используйте label1.Text
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Возвращение на Form4
            this.Close();
        }
    }
}
