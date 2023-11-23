namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Додайте колонки до ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Місяць", 200);
            listView1.Columns.Add("Борг", 200);
            listView1.Columns.Add("Відсоток", 200);
            listView1.Columns.Add("Платіж", 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            double loanAmount = double.Parse(textBox1.Text);
            int loanTermMonths = int.Parse(textBox2.Text);
            double annualInterestRate = double.Parse(textBox3.Text);

            listView1.Items.Clear();

            double monthlyInterestRate = annualInterestRate / 12 / 100;
            double monthlyPayment = loanAmount * (monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -loanTermMonths)));

            for (int month = 1; month <= loanTermMonths; month++)
            {
                double interestPayment = loanAmount * monthlyInterestRate;
                double principalPayment = monthlyPayment - interestPayment;

                ListViewItem item = new ListViewItem(month.ToString());
                item.SubItems.Add(loanAmount.ToString("N2"));
                item.SubItems.Add(interestPayment.ToString("N2"));
                item.SubItems.Add(monthlyPayment.ToString("N2"));

                listView1.Items.Add(item);

                loanAmount -= principalPayment;
            }
        }
    }
}