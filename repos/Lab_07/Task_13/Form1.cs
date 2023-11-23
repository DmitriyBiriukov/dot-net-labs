namespace Task_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) // Для Cmd+A
            {
                // Додати нову кнопку на форму
                Button newButton = new Button();
                newButton.Text = "button";
                newButton.Size = new System.Drawing.Size(100, 50);
                newButton.Location = new System.Drawing.Point((this.ClientSize.Width - newButton.Width) / 2, (this.ClientSize.Height - newButton.Height) / 2);
                this.Controls.Add(newButton);
            }
            else if (e.Control && e.KeyCode == Keys.S) // Змінено з Ctrl+D на Ctrl+S
            {
                // Видалити останню кнопку на формі (якщо є)
                if (this.Controls.Count > 0)
                {
                    Control lastControl = this.Controls[this.Controls.Count - 1];
                    if (lastControl is Button)
                    {
                        this.Controls.Remove(lastControl);
                        lastControl.Dispose();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Встановлюємо KeyPreview на true, щоб форма отримувала клавішні події
            this.KeyPreview = true;
        }
       
    }
}