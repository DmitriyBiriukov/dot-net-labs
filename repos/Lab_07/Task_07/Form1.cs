namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це натискання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Змінюємо вигляд рядка тексту при натисканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Bold);
                    clickedLabel.ForeColor = Color.Red;
                }
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це відпускання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Повертаємо вигляд рядка тексту до початкового стану при відпусканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Regular);
                    clickedLabel.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це натискання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Змінюємо вигляд рядка тексту при натисканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Bold);
                    clickedLabel.ForeColor = Color.Red;
                }
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це відпускання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Повертаємо вигляд рядка тексту до початкового стану при відпусканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Regular);
                    clickedLabel.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це натискання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Змінюємо вигляд рядка тексту при натисканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Bold);
                    clickedLabel.ForeColor = Color.Red;
                }
            }
        }


        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            // Перевірка, чи це відпускання лівої кнопки миші
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // Повертаємо вигляд рядка тексту до початкового стану при відпусканні
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Regular);
                    clickedLabel.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}