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
            // ��������� ������ � ��������� toolStripStatusLabel2 ����� ������� ������� ��� ������ � textBox1
            string textWithoutSpaces = textBox1.Text.Replace(" ", "");
            toolStripStatusLabel2.Text = $"ʳ������ ������� (��� ������): {textWithoutSpaces.Length}";

            // ��������� toolStripStatusLabel1 � ������������ �������� ��� (24-�������� ������)
            toolStripStatusLabel1.Text = $"�������� ���: {DateTime.Now.ToString("HH:mm:ss")}";
        }
    }
}