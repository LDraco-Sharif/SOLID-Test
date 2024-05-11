using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.SRP
{
    public class MailSender
    {
        public void SendMail(string body)
        {
            Console.WriteLine(body);
        }
    }
}
