using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������� � ����������� ������ �����
            Label label1 = new Label();
            label1.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Gray;
            label1.BackColor = Color.Red;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.AutoSize = false;
            label1.Width = 300;
            label1.Height = 50;
            label1.Text = "�����1";

            // ����������� ������ ����� �� ������ �����
            label1.Location = new Point((this.Width - label1.Width) / 2, (this.Height - label1.Height * 3) / 2);

            // ������� � ����������� ������ �����
            Label label2 = new Label();
            label2.Font = new Font("Arial", 17, FontStyle.Underline);
            label2.ForeColor = Color.Brown;
            label2.BackColor = Color.Purple;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.AutoSize = false;
            label2.Width = 300;
            label2.Height = 50;
            label2.Text = "�����2";

            // ����������� ������ ����� ��� ������
            label2.Location = new Point((this.Width - label2.Width) / 2, label1.Bottom + 10);

            // ������� � ����������� ������ �����
            Label label3 = new Label();
            label3.Font = new Font("Arial", 13, FontStyle.Bold);
            label3.ForeColor = Color.Pink;
            label3.BackColor = Color.Blue;
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.AutoSize = false;
            label3.Width = 300;
            label3.Height = 50;
            label3.Text = "�����3";

            // ����������� ������ ����� ��� ������
            label3.Location = new Point((this.Width - label3.Width) / 2, label2.Bottom + 10);

            // ��������� ������ �� �����
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
        }
    }
}
