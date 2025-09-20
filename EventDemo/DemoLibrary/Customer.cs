using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public Account CheckingAccount { get; set; }
        public Account SavingsAccount { get; set; }

        public Customer(string name)
        {
            this.CustomerName = name;
            this.CheckingAccount = new Account();
            this.SavingsAccount = new Account();
        }
    }
}
