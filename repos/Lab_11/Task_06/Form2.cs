using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        private FontDialog fontDialog1 = new FontDialog(); // Перемістили ініціалізацію fontDialog1 сюди

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public Font GetSelectedFont()
        {
            return fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Відобразіть діалогове вікно вибору кольору і застосуйте вибраний колір до компонентів основної форми
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.BackColor = colorDialog1.Color;
                // Додайте код для зміни кольору інших компонентів за необхідності
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Відобразіть діалогове вікно вибору шрифту і застосуйте вибраний шрифт до компонентів основної форми
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.Font = fontDialog1.Font;
                // Додайте код для зміни шрифту інших компонентів за необхідності
            }
        }
    }
}
