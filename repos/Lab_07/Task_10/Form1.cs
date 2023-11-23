namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Додаємо обробник подій для всіх текстових полів
            textBox1.Enter += TextBox_Enter;
            textBox1.Leave += TextBox_Leave;
            textBox2.Enter += TextBox_Enter;
            textBox2.Leave += TextBox_Leave;
            textBox3.Enter += TextBox_Enter;
            textBox3.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox enteredTextBox = sender as TextBox;
            if (enteredTextBox != null)
            {
                // Збережемо початковий розмір TextBox
                enteredTextBox.Tag = enteredTextBox.Size;

                // Змінюємо розмір TextBox
                enteredTextBox.Width -= 1;
                enteredTextBox.Height -= 1;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox leftTextBox = sender as TextBox;
            if (leftTextBox != null && leftTextBox.Tag is Size)
            {
                // Повертаємо розмір TextBox до початкового стану
                leftTextBox.Size = (Size)leftTextBox.Tag;
            }
        }
    }
}
