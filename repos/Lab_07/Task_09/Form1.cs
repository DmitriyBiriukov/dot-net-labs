namespace Task_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox enteredTextBox = sender as TextBox;
            if (enteredTextBox != null)
            {
                // ��������� ���������� ����� TextBox
                enteredTextBox.Tag = enteredTextBox.Size;

                // ������� ����� TextBox
                enteredTextBox.Width -= 10;
                enteredTextBox.Height -= 10;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox leftTextBox = sender as TextBox;
            if (leftTextBox != null && leftTextBox.Tag is Size)
            {
                // ��������� ����� TextBox �� ����������� �����
                leftTextBox.Size = (Size)leftTextBox.Tag;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox leftTextBox = sender as TextBox;
            if (leftTextBox != null && leftTextBox.Tag is Size)
            {
                // ��������� ����� TextBox �� ����������� �����
                leftTextBox.Size = (Size)leftTextBox.Tag;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
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

        private void textBox3_Leave(object sender, EventArgs e)
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