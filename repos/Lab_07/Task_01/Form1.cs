using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "�� ��������� �� ����� ������";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "�� ��������� �� ����� ������";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "�� ��������� �� ����� ������";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // �����������: ������������ ������� Label
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
        }
    }
}
