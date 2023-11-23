using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            // ����'���� ������ ��������� ���� ��� ��� ������
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = sender as Button;
            if (enteredButton != null)
            {
                // ��������� ���������� ����� ������
                enteredButton.Tag = enteredButton.Size;

                // ������� ����� ������
                enteredButton.Width -= 1;
                enteredButton.Height -= 1;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button leftButton = sender as Button;
            if (leftButton != null && leftButton.Tag is Size)
            {
                // ��������� ����� ������ �� ����������� �����
                leftButton.Size = (Size)leftButton.Tag;
            }
        }
    }
}
