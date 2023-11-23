namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = sender as Button;
            if (enteredButton != null)
            {
                // Збережемо початковий розмір кнопки
                enteredButton.Tag = enteredButton.Size;

                // Змінюємо розмір кнопки
                enteredButton.Width -= 10;
                enteredButton.Height -= 10;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button leftButton = sender as Button;
            if (leftButton != null && leftButton.Tag is Size)
            {
                // Повертаємо розмір кнопки до початкового стану
                leftButton.Size = (Size)leftButton.Tag;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = sender as Button;
            if (enteredButton != null)
            {
                // Збережемо початковий розмір кнопки
                enteredButton.Tag = enteredButton.Size;

                // Змінюємо розмір кнопки
                enteredButton.Width -= 1;
                enteredButton.Height -= 1;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button leftButton = sender as Button;
            if (leftButton != null && leftButton.Tag is Size)
            {
                // Повертаємо розмір кнопки до початкового стану
                leftButton.Size = (Size)leftButton.Tag;
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = sender as Button;
            if (enteredButton != null)
            {
                // Збережемо початковий розмір кнопки
                enteredButton.Tag = enteredButton.Size;

                // Змінюємо розмір кнопки
                enteredButton.Width -= 1;
                enteredButton.Height -= 1;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Button leftButton = sender as Button;
            if (leftButton != null && leftButton.Tag is Size)
            {
                // Повертаємо розмір кнопки до початкового стану
                leftButton.Size = (Size)leftButton.Tag;
            }
        }
    }
}