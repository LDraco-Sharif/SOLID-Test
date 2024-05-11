using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.OCP
{
    public enum MessageType
    {
        mail,
        sms,
        email
    }
    abstract public class MessageService
    {
        //public void SendMessage(string message, MessageType messageType)
        //{
        //    switch (messageType)
        //    {
        //        case MessageType.mail:
        //            Console.WriteLine("Sent by Mail: " + message);
        //            break;
        //        case MessageType.sms:
        //            Console.WriteLine("Sent by SMS: " + message);
        //            break;
        //        case MessageType.email:
        //            Console.WriteLine("Sent by E-Mail: " + message);
        //            break;
        //    }
        //}

        abstract public void SendMessage(string message);

    }

    public class MailService : MessageService
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("Sent by Mail: " + message);
        }
    }

    public class SmsService : MessageService
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("Sent by SMS: " + message);
        }
    }

    public class EmailService : MessageService
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("Sent by E-Mail: " + message);
        }
    }


}
