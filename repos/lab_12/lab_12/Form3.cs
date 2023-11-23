// Form3.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Form3.cs
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка существования пользователя
            string usernameToCheck = textBox1.Text;
            string passwordToCheck = textBox2.Text;

            string userFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\data.txt"; // Путь к файлу с пользователями (замените на свой путь)

            if (CheckUserCredentials(usernameToCheck, passwordToCheck, userFilePath, out string userEmail))
            {
                // Переход на Form4
                Form4 form4 = new Form4(userEmail, usernameToCheck, passwordToCheck);
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }


        private bool CheckUserCredentials(string username, string password, string filePath, out string userEmail)
        {
            userEmail = ""; // Инициализируем userEmail пустой строкой

            // Проверка существования пользователя в файле (пример использования, лучше использовать базу данных)
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && parts[1] == username && parts[2] == password)
                    {
                        userEmail = parts[0]; // Получаем email из файла
                        return true;
                    }
                }
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
