using System;
using System.Windows.Forms; // ���������, ��� ��� ������������ ���� ����������

namespace Task_08
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
            // ����'���� ������ ��������� ���� ��� ��� ����� ������
            label1.MouseDown += Label_MouseDown;
            label1.MouseUp += Label_MouseUp;
            label2.MouseDown += Label_MouseDown;
            label2.MouseUp += Label_MouseUp;
            label3.MouseDown += Label_MouseDown;
            label3.MouseUp += Label_MouseUp;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            // ��������, �� �� ���������� ��� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // ������� ������ ����� ������ ��� ���������
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Bold);
                    clickedLabel.ForeColor = Color.Red;
                }
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            // ��������, �� �� ���������� ��� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // ��������� ������ ����� ������ �� ����������� ����� ��� ���������
                    clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Regular);
                    clickedLabel.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}