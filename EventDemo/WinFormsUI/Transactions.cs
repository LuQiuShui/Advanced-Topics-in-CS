using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Transactions : Form
    {
        private Customer _customer;

        public Transactions(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            label4.Text = _customer.CustomerName;
            _customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
            label6.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool paymentResult = _customer.CheckingAccount.MakePayment("Credit Card Purchase", numericUpDown1.Value, _customer.SavingsAccount);
            numericUpDown1.Value = 0;
        }
    }
}
