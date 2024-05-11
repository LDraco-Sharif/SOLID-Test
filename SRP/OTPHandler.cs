namespace SOLID_Test.SRP
{
    public class OTPHandler
    {
        private readonly MailSender _mailSender;

        public OTPHandler(MailSender mailSender) { 
            _mailSender = mailSender;
        }

        //public void HandleOTP()
        //{
        //    Random random = new Random();
        //    int value = random.Next(0, 99999);
        //    string valueInString = value.ToString("00000");

        //    Console.WriteLine("Sending Mail: OTP - " + valueInString);
        //}

        public void HandleOTP()
        {
            Random random = new Random();
            int value = random.Next(0, 99999);
            string valueInString = value.ToString("00000");

            string message = "Sending Mail: OTP - " + valueInString;
            _mailSender.SendMail(message);
        }
    }
}
