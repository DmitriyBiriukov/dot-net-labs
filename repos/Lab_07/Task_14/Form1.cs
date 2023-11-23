using System;
using System.Windows.Forms;

namespace Task_14
{
    public partial class Form1 : Form
    {
        private bool dialogShown = false;

        public Form1()
        {
            InitializeComponent();
            // ������ �������� ��䳿 Load �� �����
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!dialogShown)
            {
                dialogShown = true;

                // �������� �������� ���� � �������
                DialogResult result = MessageBox.Show("����������� ����� �������?", "�����", MessageBoxButtons.YesNo);

                // ���������� ��������� ���������� ����
                if (result == DialogResult.Yes)
                {
                    // ���� ���������� ����� "���", �� ����������� �����
                    // ������� ����� � ������������ ����� (���������, ������ �������� ������)
                    this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 2);
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new System.Drawing.Point(0, 0);

                    // ������� ��� ��� ������������ ����� ������� ���
                }
                else
                {
                    // ���� ���������� ����� "Ͳ", �� �� ����������� �����
                    this.Close();
                }
            }

            // ��������� �������� ��䳿 Load
            this.Load -= Form1_Load;
        }
    }
}
