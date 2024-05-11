using SOLID_Test.DIP.PaymentOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.DIP.PaymentAdapters
{
    internal class PaypalAdapter : IPayment
    {
        private Paypal _paypal;
        private string _user;

        private bool initialized = false;
        public void Initialize(string user)
        {
            _user = user;
            _paypal = new Paypal(_user);
            initialized = true;
        }

        public void SendPayment(float valueInDollars)
        {
            if (initialized)
            {
                _paypal.pay(valueInDollars*100);
            }
            else
            {
                Console.WriteLine("Initialize first");
            }
        }
    }
}
