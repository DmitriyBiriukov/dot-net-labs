namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Видаляємо пробіли і оновлюємо toolStripStatusLabel2 згідно кількості символів без пробілів у textBox1
            string textWithoutSpaces = textBox1.Text.Replace(" ", "");
            toolStripStatusLabel2.Text = $"Кількість символів (без пробілів): {textWithoutSpaces.Length}";

            // Оновлюємо toolStripStatusLabel1 і встановлюємо поточний час (24-годинний формат)
            toolStripStatusLabel1.Text = $"Теперішній час: {DateTime.Now.ToString("HH:mm:ss")}";
        }
    }
}