namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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

        private void label1_MouseUp(object sender, MouseEventArgs e)
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
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

        private void label2_MouseUp(object sender, MouseEventArgs e)
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

        private void label3_MouseDown(object sender, MouseEventArgs e)
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


        private void label3_MouseUp(object sender, MouseEventArgs e)
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