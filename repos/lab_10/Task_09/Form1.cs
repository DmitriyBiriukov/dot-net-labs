using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // �������������� NotifyIcon
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Application; // ������������� ������
            notifyIcon1.Text = "��� ��������"; // ������������� ����� �����������

            // ���������� ����������� ���� � NotifyIcon
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            // ��������� ���������� ������� �� ������� ������ �� ������, ����� ���������� ��� �������� �����
            notifyIcon1.DoubleClick += ToggleFormVisibility;
        }

        private void ToggleFormVisibility(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // ���� ����� ��������, ���������� �
                Show();
                WindowState = FormWindowState.Normal;
            }
            else
            {
                // ���� ����� ��� ������, �������� �
                Hide();
                WindowState = FormWindowState.Minimized;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ��������� ������ � ��������� toolStripStatusLabel2 ����� ������� ������� ��� ������ � textBox1
            string textWithoutSpaces = textBox1.Text.Replace(" ", "");
            toolStripStatusLabel2.Text = $"ʳ������ ������� (��� ������): {textWithoutSpaces.Length}";

            // ��������� toolStripStatusLabel1 � ������������ �������� ��� (24-�������� ������)
            toolStripStatusLabel1.Text = $"�������� ���: {DateTime.Now.ToString("HH:mm:ss")}";
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