using SOLID_Test.DIP;
using SOLID_Test.DIP.PaymentAdapters;
using SOLID_Test.ISP;
using SOLID_Test.LSP;
using SOLID_Test.OCP;
using SOLID_Test.SRP;

//Single Responsibility Principle
var mailSender = new MailSender();
var otpHandler = new OTPHandler(mailSender);

otpHandler.HandleOTP();

Console.WriteLine("\n");

//Open-Closed Principle

//var messageService = new MessageSender();
//messageService.SendMessage("This is a demo message.", MessageType.mail);
//messageService.SendMessage("This is a demo message.", MessageType.sms);
//messageService.SendMessage("This is a demo message.", MessageType.email);

MessageService mailService = new MailService();
MessageService smsService = new SmsService();
MessageService emailService = new EmailService();

var message = "This is a demo message.";
mailService.SendMessage(message);
smsService.SendMessage(message);
emailService.SendMessage(message);

Console.WriteLine("\n");


//Liskov Substitution Principle

Sequence sq = new Sequence();
var val1 = sq.ReturnSequence();
Console.WriteLine("Value: " + val1.GetType().GetProperty("value")?.GetValue(val1, null));

Sequence sq2 = new RandomSequence();
var val2 = sq2.ReturnSequence();
Console.WriteLine("Value: " + val2.GetType().GetProperty("value")?.GetValue(val2, null)); //Doesn't work




//Interface Segregation Principle

//IEnemy enemy = new Swordsman("Swords1");
//enemy.Move(); //No issue here
//enemy.Attack();

//IEnemy enemy = new Turret("Turret1");
//enemy.Move(); //Cannot actually implement it
//enemy.Attack();

IEnemy enemy = new Turret("Turret1");
enemy.Attack();

IMovingEnemy movingEnemy = new Swordsman("Swords1");
movingEnemy.Attack();
movingEnemy.Move();

Console.WriteLine("\n");


//Dependency Inversion Principle
IPayment payment1 = new CreditCardAdapter();
IPayment payment2 = new PaypalAdapter();

payment1.Initialize("User");
payment2.Initialize("User");

payment1.SendPayment(100);
payment2.SendPayment(100);

