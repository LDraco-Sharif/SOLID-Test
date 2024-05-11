using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.DIP.PaymentOptions
{
    public class Paypal
    {
        private string _user;
        public Paypal(string user) 
        {
            _user = user;
        }

        public void pay(float valueInCents)
        {
            Console.WriteLine(_user + " paid " + valueInCents + " cents." );
        }
    }
}
