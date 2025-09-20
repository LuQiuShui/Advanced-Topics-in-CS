using DemoLibrary;

namespace WinFormsUI
{
    public partial class Dashboard : Form
    {
        Customer customer = new Customer("Tim Corey");
        public Dashboard()
        {
            InitializeComponent();
            LoadTestingData();
            WireUpForm();
        }

        private void LoadTestingData()
        {
            customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M);
            customer.SavingsAccount.AddDeposit("Initial Balance", 98.45M);
        }

        private void WireUpForm()
        {
            label3.Text = customer.CustomerName;
            listBox1.DataSource = customer.CheckingAccount.Transactions;
            listBox2.DataSource = customer.SavingsAccount.Transactions;
            label5.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
            label7.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);

            customer.CheckingAccount.TransactionApprovedEvent += CheckingAccount_TransactionApprovedEvent;
            customer.SavingsAccount.TransactionApprovedEvent += SavingsAccount_TransactionApprovedEvent;
            customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_TransactionApprovedEvent(object sender, string e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = customer.CheckingAccount.Transactions;
            label5.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void SavingsAccount_TransactionApprovedEvent(object sender, string e)
        {
            listBox2.DataSource = null;
            listBox2.DataSource = customer.SavingsAccount.Transactions;
            listBox2.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
            label11.Text = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e.AmountOverdrafted)}";
            e.CancelTransaction = checkBox1.Checked;
            label11.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(customer);
            transactions.Show();
        }
    }
}
