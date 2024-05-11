using SOLID_Test.DIP.PaymentOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.DIP.PaymentAdapters
{
    public class CreditCardAdapter : IPayment
    {
        private CreditCard _creditCard;
        private string _user;

        private bool initialized = false;
        public void Initialize(string user)
        {
            _user = user;
           _creditCard = new CreditCard();
            initialized = true;
        }

        public void SendPayment(float valueInDollars)
        {
            if(initialized)
            {
                _creditCard.pay(_user, valueInDollars);
            }
            else
            {
                Console.WriteLine("Initialize first");
            }
        }
    }
}
