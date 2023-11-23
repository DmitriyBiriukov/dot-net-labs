using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Инициализируем NotifyIcon
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Application; // Устанавливаем значок
            notifyIcon1.Text = "Моя програма"; // Устанавливаем текст уведомления

            // Подключаем контекстное меню к NotifyIcon
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            // Добавляем обработчик события на двойной щелчок по значку, чтобы показывать или скрывать форму
            notifyIcon1.DoubleClick += ToggleFormVisibility;
        }

        private void ToggleFormVisibility(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // Если форма свернута, показываем её
                Show();
                WindowState = FormWindowState.Normal;
            }
            else
            {
                // Если форма уже видима, скрываем её
                Hide();
                WindowState = FormWindowState.Minimized;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Видаляємо пробіли і оновлюємо toolStripStatusLabel2 згідно кількості символів без пробілів у textBox1
            string textWithoutSpaces = textBox1.Text.Replace(" ", "");
            toolStripStatusLabel2.Text = $"Кількість символів (без пробілів): {textWithoutSpaces.Length}";

            // Оновлюємо toolStripStatusLabel1 і встановлюємо поточний час (24-годинний формат)
            toolStripStatusLabel1.Text = $"Теперішній час: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void ShowForm()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void HideForm()
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideForm();
        }


    }
}