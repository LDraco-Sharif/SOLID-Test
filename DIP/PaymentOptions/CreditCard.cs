using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.DIP.PaymentOptions
{
    public class CreditCard
    {
        public void pay(string user, float valueInDollars)
        {
            Console.WriteLine(user + " paid " + valueInDollars + " dollars.");
        }
    }
}
