namespace Task_03_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка наличия введенных данных
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Попытка парсинга введенных данных
            if (!double.TryParse(textBox1.Text, out double x) || !double.TryParse(textBox2.Text, out double y) || !double.TryParse(textBox3.Text, out double z))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Рассчет выражения
            double result = 1.0;

            for (int i = 1; i <= y; i++)
            {
                double numerator = i + z;
                double denominator = x - y + Math.Pow(i, 2);

                if (denominator == 0)
                {
                    MessageBox.Show("Ошибка: Знаменатель равен нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result *= Math.Sqrt(numerator / denominator);
            }

            // Вывод результата
            label4.Text = $"Результат выражения: {result}";
        }
    }
}