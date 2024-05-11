using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.DIP
{
    public interface IPayment
    {
        public void Initialize(string user);
        public void SendPayment(float value);
    }
}
