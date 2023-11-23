using System;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            // ���������, ��� ���� ������ ���� ���������, �������������� �������� sender
            ToolStripButton button = (ToolStripButton)sender;

            // �������� ����� ������� ��� ��������� ������
            string tooltipText = button.ToolTipText;

            // �������� ����� ������� � ���������� ���
            MessageBox.Show(tooltipText, "ϳ������");
        }
    }
}
