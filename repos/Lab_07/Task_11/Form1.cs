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
            // ������������ ���� KeyDown
            if (e.KeyCode == Keys.Decimal && (sender as TextBox).Text.Contains("."))
            {
                e.SuppressKeyPress = true; // ����������� ���������� ��������� �����
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // ������������ ���� KeyPress
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // ����������� �������� �������, ���� ���� � ��������� �����
            }

            // �������� �� ������� ���������� ����� �� ������� ����
            if (e.KeyChar == '.')
            {
                if ((sender as TextBox).Text.Contains("."))
                {
                    e.Handled = true; // ����������� ���������� ��������� �����
                }
                else if ((sender as TextBox).Text.Length >= 10)
                {
                    e.Handled = true; // ����������� �������� ����� 10 ���� ���� ��������� �����
                }
            }
            else if (char.IsDigit(e.KeyChar))
            {
                if (((sender as TextBox).Text.Length >= 10 && !((sender as TextBox).Text.Contains("."))) ||
                    ((sender as TextBox).Text.Length >= 11 && ((sender as TextBox).Text.Contains("."))))
                {
                    e.Handled = true; // ����������� �������� ����� 10 ���� ����� ���������� ������ ��� ����� 11 � ���
                }
            }
        }

    }
}