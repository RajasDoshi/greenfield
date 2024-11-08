using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Penalty
{
    public class PenaltyHandler
    {
        public static void serviceDisconnect(float amount)
        {
            Console.WriteLine("4Disconnection" + amount);
        }
        public static void servicenotification(float amount)
        {
            Console.WriteLine("5Disconnection" + amount);
        }

    }
}
