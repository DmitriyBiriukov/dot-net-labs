namespace Task_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderDialog.SelectedPath;

                    // ���������� ���� � ��������� ����� � Label
                    label1.Text = "" + selectedFolderPath;

                    // ������� ListBox � PictureBox
                    listBox1.Items.Clear();
                    pictureBox1.Image = null;

                    // ��������� ����������� �� ��������� ����� � ��������� �� ���� � ListBox
                    string[] imageFiles = Directory.GetFiles(selectedFolderPath, "*.png");
                    foreach (string imagePath in imageFiles)
                    {
                        listBox1.Items.Add(imagePath);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // ��� ������ �������� �� ListBox, ���������� ��������������� ����������� � PictureBox
                pictureBox1.ImageLocation = listBox1.SelectedItem.ToString();
            }
        }
    }
}