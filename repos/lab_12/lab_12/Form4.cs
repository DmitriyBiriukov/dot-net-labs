using lab_12;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form4 : Form
    {
        public string userEmail;
        public string username;
        public string password;
        private Dictionary<string, List<string>> messages; // Словарь для хранения сообщений

        public Form4(string userEmail, string username, string password)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            this.username = username;
            this.password = password;
            this.messages = LoadMessages(); // Загружаем сообщения при загрузке формы

            // Отображение данных пользователя при загрузке формы
            label5.Text = userEmail;
            label6.Text = username;
            label7.Text = password;
        }

        private Dictionary<string, List<string>> LoadMessages()
        {
            // Загрузка сообщений из файла
            Dictionary<string, List<string>> loadedMessages = new Dictionary<string, List<string>>();
            string messagesFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\message.txt"; // Путь к файлу с сообщениями (замените на свой путь)

            if (File.Exists(messagesFilePath))
            {
                string[] lines = File.ReadAllLines(messagesFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string recipient = parts[0];
                        string message = parts[1];

                        if (!loadedMessages.ContainsKey(recipient))
                        {
                            loadedMessages.Add(recipient, new List<string>());
                        }

                        loadedMessages[recipient].Add(message);
                    }
                }
            }

            return loadedMessages;
        }

        private void SaveMessages()
        {
            // Сохранение сообщений в файл
            string messagesFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\message.txt"; // Путь к файлу с сообщениями (замените на свой путь)

            using (StreamWriter writer = new StreamWriter(messagesFilePath))
            {
                foreach (var entry in messages)
                {
                    foreach (string message in entry.Value)
                    {
                        writer.WriteLine($"{entry.Key}|{message}");
                    }
                }
            }
        }

        public void SendMessage(string recipient, string message)
        {
            // Отправка сообщения
            if (!messages.ContainsKey(recipient))
            {
                messages.Add(recipient, new List<string>());
            }

            messages[recipient].Add(message);
            SaveMessages();
        }

        public List<string> GetMessages(string recipient)
        {
            // Получение сообщений для указанного получателя
            if (messages.ContainsKey(recipient))
            {
                return messages[recipient];
            }

            return new List<string>();
        }

        public List<string> GetMessageSenders()
        {
            // Получение списка отправителей сообщений
            List<string> senders = new List<string>(messages.Keys);
            return senders;
        }

        public string GetLastMessage(string sender)
        {
            // Получение последнего сообщения от указанного отправителя
            if (messages.ContainsKey(sender) && messages[sender].Count > 0)
            {
                return messages[sender][messages[sender].Count - 1];
            }

            return string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Переход на Form7
            Form7 form7 = new Form7(this);
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Переход на Form5
            Form5 form5 = new Form5(this);
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Переход на Form6
            Form6 form6 = new Form6(this);
            this.Hide();
            form6.ShowDialog();
            this.Close();
        }
    }
}
