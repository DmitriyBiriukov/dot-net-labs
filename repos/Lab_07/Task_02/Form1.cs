using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers(); // ����������� ��������� ����
        }

        private void InitializeEventHandlers()
        {
            // ����'���� ��������� ���� �� ������
            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                label1.Text = "�� ��������� �� " + clickedButton.Text;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // �����������: ������������ ������� Label
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
        }
    }
}
