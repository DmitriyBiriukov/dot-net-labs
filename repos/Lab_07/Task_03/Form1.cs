using System;
using System.Windows.Forms;

namespace Task_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // �������� �������� ����� ������
                float currentFontSize = clickedLabel.Font.Size;

                // �������� ����� ������ �� 1 pt
                float newFontSize = currentFontSize - 1;

                // ̳�������� ����� ������, ���� �� ������ 1 pt
                if (newFontSize < 1)
                {
                    newFontSize = 1;
                }

                // ��������� ����� ��'��� ������ � ��������� �������
                Font newFont = new Font(clickedLabel.Font.FontFamily, newFontSize);

                // ������������ ����� ����� ��� Label
                clickedLabel.Font = newFont;
            }
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // �������� �������� ����� ������
                float currentFontSize = clickedLabel.Font.Size;

                // �������� ����� ������ �� 1 pt
                float newFontSize = currentFontSize - 1;

                // ̳�������� ����� ������, ���� �� ������ 1 pt
                if (newFontSize < 1)
                {
                    newFontSize = 1;
                }

                // ��������� ����� ��'��� ������ � ��������� �������
                Font newFont = new Font(clickedLabel.Font.FontFamily, newFontSize);

                // ������������ ����� ����� ��� Label
                clickedLabel.Font = newFont;
            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // �������� �������� ����� ������
                float currentFontSize = clickedLabel.Font.Size;

                // �������� ����� ������ �� 1 pt
                float newFontSize = currentFontSize - 1;

                // ̳�������� ����� ������, ���� �� ������ 1 pt
                if (newFontSize < 1)
                {
                    newFontSize = 1;
                }

                // ��������� ����� ��'��� ������ � ��������� �������
                Font newFont = new Font(clickedLabel.Font.FontFamily, newFontSize);

                // ������������ ����� ����� ��� Label
                clickedLabel.Font = newFont;
            }
        }
    }
}