using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Account
    {
        public event EventHandler<string> TransactionApprovedEvent;    // 交易批准触发事件
        public event EventHandler<OverdraftEventArgs> OverdraftEvent;  // 支票透支触发事件

        public string AccountName { get; set; }
        public decimal Balance { get; private set; }
        private List<string> _transactions = new List<string>();

        public IReadOnlyList<string> Transactions
        {
            get { return _transactions.AsReadOnly(); }
        }

        public bool AddDeposit(string depositName, decimal amount)
        {
            _transactions.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
            Balance += amount;
            TransactionApprovedEvent?.Invoke(this, depositName);
            return true;
        }

        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            if (Balance >= amount)
            {
                _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                Balance -= amount;
                TransactionApprovedEvent?.Invoke(this, paymentName);
                return true;
            }
            else
            {
                if (backupAccount != null)
                {
                    if ((backupAccount.Balance + Balance) >= amount)
                    {
                        decimal amountNeeded = amount - Balance;
                        OverdraftEventArgs args = new OverdraftEventArgs(amountNeeded, "Extra Info");

                        OverdraftEvent?.Invoke(this, args);

                        if (args.CancelTransaction == true)
                        {
                            return false;
                        }

                        bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

                        if (overdraftSucceeded == false)
                        {
                            return false;
                        }

                        AddDeposit("Overdraft Protection Deposit", amountNeeded);

                        _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                        Balance -= amount;
                        TransactionApprovedEvent?.Invoke(this, paymentName);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
