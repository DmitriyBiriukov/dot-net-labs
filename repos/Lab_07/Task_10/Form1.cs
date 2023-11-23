namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������ �������� ���� ��� ��� ��������� ����
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
                // ��������� ���������� ����� TextBox
                enteredTextBox.Tag = enteredTextBox.Size;

                // ������� ����� TextBox
                enteredTextBox.Width -= 1;
                enteredTextBox.Height -= 1;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox leftTextBox = sender as TextBox;
            if (leftTextBox != null && leftTextBox.Tag is Size)
            {
                // ��������� ����� TextBox �� ����������� �����
                leftTextBox.Size = (Size)leftTextBox.Tag;
            }
        }
    }
}
