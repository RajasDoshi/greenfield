using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatureApp
{
    public delegate void Operation(float factor);
    public static class TaxHandler
    {  
        public static void  PayIcometax(float factor) {
            Console.WriteLine("1hdoefhefh"+factor);
        }
        public static void Payservicetax( float factor)
        {
            Console.WriteLine("2hdoefhefh"+factor);

        }
        public static void PayIcomtax(float factor)
        {
            Console.WriteLine("3hdoefhefh" + factor);
        }
    }
    public static class penaltyhandler
    {
        public static void serviceDisconnect(float amount)
        {
            Console.WriteLine("4Disconnection" +amount);
        }
        public static void servicenotification(float amount)
        {
            Console.WriteLine("5Disconnection" + amount);
        }

    }
}
