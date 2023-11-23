// Form7.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form7 : Form
    {
        private Form4 parentForm;
        private string originalUserEmail;
        private string originalUsername;
        private string originalPassword;

        public Form7(Form4 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            // Сохраняем оригинальные данные пользователя
            originalUserEmail = parentForm.userEmail;
            originalUsername = parentForm.username;
            originalPassword = parentForm.password;

            // Отображение текущих данных пользователя при загрузке формы
            textBox1.Text = originalUserEmail;
            textBox2.Text = originalUsername;
            textBox3.Text = originalPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Изменение данных пользователя
            parentForm.userEmail = textBox1.Text;
            parentForm.username = textBox2.Text;
            parentForm.password = textBox3.Text;

            // Сохранение изменений в файле или базе данных
            SaveUserData();

            MessageBox.Show("Данные пользователя обновлены!");

            parentForm.Show(); // Используем Show() вместо ShowDialog()
            this.Close();
        }

        private void SaveUserData()
        {
            // Сохранение данных пользователя в файле или базе данных
            string usersFilePath = @"C:\Users\dmitriybirukov\source\repos\lab_12\lab_12\data.txt"; // Путь к файлу с пользователями (замените на свой путь)

            if (File.Exists(usersFilePath))
            {
                string[] lines = File.ReadAllLines(usersFilePath);
                using (StreamWriter writer = new StreamWriter(usersFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string userEmail = parts[0];
                            string username = parts[1];
                            string password = parts[2];

                            if (userEmail == originalUserEmail && username == originalUsername && password == originalPassword)
                            {
                                // Обновляем данные пользователя
                                writer.WriteLine($"{parentForm.userEmail},{parentForm.username},{parentForm.password}");
                            }
                            else
                            {
                                // Сохраняем остальные пользователи без изменений
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }
    }
}
