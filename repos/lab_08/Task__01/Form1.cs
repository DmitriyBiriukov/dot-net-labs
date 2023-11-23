namespace Task__01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка, что все четыре TextBox'а заполнены
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                // Один из TextBox'ов пуст, выдаем сообщение
                MessageBox.Show("Введите все данные!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Установка нового цвета фона для текстовых полей
                textBox1.BackColor = Color.Yellow; // Добавление цвета
                textBox2.BackColor = Color.Green; // Добавление цвета
                textBox3.BackColor = Color.Blue; //Добавление цвета
                textBox4.BackColor = Color.Red; // Добавление вета

                // Опциональное сообщение об успешной отправке
                MessageBox.Show("Данные отправлены! Спасибо)");

                // Вы можете изменить цвета на любые другие по вашему выбору
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            textBox3.BackColor = SystemColors.Window;
            textBox4.BackColor = SystemColors.Window;
        }
    }
}