using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Penalty;
using Taxation;
using Delegation;
namespace CsharpFeatureApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account act = new Account(15000);
            act.underbalance += PenaltyHandler.serviceDisconnect;
            act.Withdraw(8000);
            //  Handler.PayIcometax();
//act.overbalance += TaxHandler.Payservicetax;
         //   act.deposite(26000);
                Console.ReadLine();
        }
    }
}
