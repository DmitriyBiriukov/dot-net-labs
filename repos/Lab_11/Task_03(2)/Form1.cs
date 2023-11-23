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
            if (!double.TryParse(textBox1.Text, out double side1) || !double.TryParse(textBox2.Text, out double side2) || !double.TryParse(textBox3.Text, out double side3))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на возможность построения треугольника
            if (!IsTriangleValid(side1, side2, side3))
            {
                MessageBox.Show("Треугольник с такими сторонами не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Рассчет периметра
            double perimeter = side1 + side2 + side3;

            // Рассчет площади по формуле Герона
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            Form2 form2 = new Form2($"Периметр: {perimeter}", $"Площадь: {area}");
            form2.Show();
        }

        // Проверка на возможность построения треугольника
        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}