using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;

namespace Banking
{
    public class Account
    {
        public event Operation underbalance;
        public event Operation overbalance;
        public double Balance { get; set; }

        public Account(double intialAmount)
        {
            //     Console.WriteLine(Balance+"this is the balance");

            Balance = intialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result <= 10000)
            {
                underbalance(50);
            }
        }
        public void deposite(double amount)
        {
            double result = Balance + amount;
            if (result < 250000)
            {
                // underbalance(5);
                overbalance(500);
            }
        }
    }
}
