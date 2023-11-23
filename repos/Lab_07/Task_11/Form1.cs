namespace Task_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Перехоплюємо подію KeyDown
            if (e.KeyCode == Keys.Decimal && (sender as TextBox).Text.Contains("."))
            {
                e.SuppressKeyPress = true; // Забороняємо дублювання десяткової точки
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Перехоплюємо подію KeyPress
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Забороняємо введення символів, окрім цифр і десяткової точки
            }

            // Перевірка на кількість десяткових точок та кількість цифр
            if (e.KeyChar == '.')
            {
                if ((sender as TextBox).Text.Contains("."))
                {
                    e.Handled = true; // Забороняємо дублювання десяткової точки
                }
                else if ((sender as TextBox).Text.Length >= 10)
                {
                    e.Handled = true; // Забороняємо введення більше 10 цифр після десяткової точки
                }
            }
            else if (char.IsDigit(e.KeyChar))
            {
                if (((sender as TextBox).Text.Length >= 10 && !((sender as TextBox).Text.Contains("."))) ||
                    ((sender as TextBox).Text.Length >= 11 && ((sender as TextBox).Text.Contains("."))))
                {
                    e.Handled = true; // Забороняємо введення більше 10 цифр перед десятковою точкою або більше 11 з нею
                }
            }
        }

    }
}