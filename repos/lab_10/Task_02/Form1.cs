using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> photoPaths;
        private int currentPhotoIndex = 0;
        private bool isSlideshowRunning = false;
        private int slideshowInterval = 2000; // �������� �����-��� � �������������

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� ���������� ���� ������ ����� ��� ����������
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // �������� ������ ������ �� ��������� �����
                string selectedFolderPath = folderDialog.SelectedPath;
                string[] photoFiles = Directory.GetFiles(selectedFolderPath, "*.png"); // ����� �������� ���������� ������ �� ������ ����������

                // ��������� ������ ����������
                photoPaths = new List<string>(photoFiles);
                currentPhotoIndex = 0;

                if (photoPaths.Count > 0)
                {
                    DisplayCurrentPhoto();
                }
                else
                {
                    MessageBox.Show("� ��������� ����� ��� ����������.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                currentPhotoIndex = (currentPhotoIndex + 1) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                currentPhotoIndex = (currentPhotoIndex - 1 + photoPaths.Count) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }

        private void DisplayCurrentPhoto()
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                string currentPhotoPath = photoPaths[currentPhotoIndex];
                pictureBox1.Image = new System.Drawing.Bitmap(currentPhotoPath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                if (isSlideshowRunning)
                {
                    // ������������� �����-���
                    isSlideshowRunning = false;
                    button4.Text = "��������� �����-���";
                    timer1.Stop();
                }
                else
                {
                    // ��������� �����-���
                    isSlideshowRunning = true;
                    button4.Text = "STOP";
                    StartSlideshow();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isSlideshowRunning)
            {
                // ������������� �����-���, ����� �������� ��������
                isSlideshowRunning = false;
                button4.Text = "PLAY";
                timer1.Stop();
            }

            // �������� �������� �����-���
            if (slideshowInterval == 2000)
            {
                slideshowInterval = 1000; // ��������� ��� ��������� ��������, ����� �������� ��������
                button5.Text = "�2";
            }
            else
            {
                slideshowInterval = 2000;
                button5.Text = "x1";
            }
        }

        private void StartSlideshow()
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(SlideshowTimer_Tick);
                timer1.Interval = slideshowInterval;
                timer1.Start();
            }
        }


        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            if (photoPaths != null && photoPaths.Count > 0)
            {
                currentPhotoIndex = (currentPhotoIndex + 1) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }

    }
}
