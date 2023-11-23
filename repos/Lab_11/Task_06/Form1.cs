namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            comboBox1.Text = "";
            comboBox2.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� TextBox'� � 1 �� 5
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("������� ��� ������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ��������� ComboBox'� � 1 �� 2
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("������� ��� ������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ��������� RadioButton'� � 1 �� 4
            if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked))
            {
                MessageBox.Show("������� ��� ������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ��������� RadioButton'� � 5 �� 6
            if (!(radioButton5.Checked || radioButton6.Checked))
            {
                MessageBox.Show("������� ��� ������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �������� ������, � ������� ����� ��������� ���������
            string message = $" {groupBox1.Text}:\n {label2.Text}: {textBox1.Text}\n{label3.Text}: {textBox2.Text} \n{label4.Text}: {textBox3.Text}\n{label5.Text}: {textBox4.Text}\n {groupBox2.Text}:\n {label6.Text}: {comboBox1.Text}\n {label7.Text}: {comboBox2.Text}\n {label8.Text}: {textBox5.Text} \n";

            // �������� ���������� ��� �������� ������ ��������� �����������
            string selectedRadioButtonTextPanel1 = "";
            string selectedRadioButtonTextPanel2 = "";

            // ��������� ��������� RadioButton �� panel1 � ��������� �� ����� ����������
            if (radioButton1.Checked) selectedRadioButtonTextPanel1 = radioButton1.Text;
            if (radioButton2.Checked) selectedRadioButtonTextPanel1 = radioButton2.Text;
            if (radioButton3.Checked) selectedRadioButtonTextPanel1 = radioButton3.Text;
            if (radioButton4.Checked) selectedRadioButtonTextPanel1 = radioButton4.Text;

            // ��������� ��������� RadioButton �� panel2 � ��������� �� ����� ����������
            if (radioButton5.Checked) selectedRadioButtonTextPanel2 = radioButton5.Text;
            if (radioButton6.Checked) selectedRadioButtonTextPanel2 = radioButton6.Text;

            // �������� ����� ��������� RadioButton � ����� ������ message
            if (!string.IsNullOrEmpty(selectedRadioButtonTextPanel1))
            {
                message += $" {groupBox3.Text}: {selectedRadioButtonTextPanel1}\n";
            }

            if (!string.IsNullOrEmpty(selectedRadioButtonTextPanel2))
            {
                message += $" {label9.Text}: {selectedRadioButtonTextPanel2}\n";
            }


            MessageBox.Show(message, "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            // ������� ���� ����� ��� ����������� � ��������� �������� ��������� Form1 � �����������
            Form2 form2 = new Form2(this);

            // ³�������� ���� ����� ��� �����������
            DialogResult result = form2.ShowDialog();

            // ��������, �� ���������� �������� "OK" � ��� �����������
            if (result == DialogResult.OK)
            {
                // ����� ����� ��� ��� ���������� � groupBox2 �� ������� ����� �� Form2
                ChangeFontForControls(groupBox2.Controls, form2.GetSelectedFont());
            }
        }

        private void ChangeFontForControls(Control.ControlCollection controls, Font newFont)
        {
            // ����� ����� ��� ��� �������� � Control.ControlCollection
            foreach (Control control in controls)
            {
                control.Font = newFont;

                // ���������� ���������� ��� ����� ��� ��������� ��������
                if (control.Controls.Count > 0)
                {
                    ChangeFontForControls(control.Controls, newFont);
                }
            }
        }




    }
}