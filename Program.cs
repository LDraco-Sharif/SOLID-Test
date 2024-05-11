using SOLID_Test.DIP;
using SOLID_Test.DIP.PaymentAdapters;
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

//Enemy enemy = new Swordsman("Swords1");
//enemy.Move(); //No issue here
//enemy.Attack();

//Enemy enemy = new Turret("Turret1");
//enemy.Move(); //Cannot actually implement it
//enemy.Attack();

Enemy enemy = new Turret("Turret1");
enemy.Attack();

MovingEnemy movingEnemy = new Swordsman("Swords1");
movingEnemy.Attack();
movingEnemy.Move();

Console.WriteLine("\n");

//





//Dependency Inversion Principle
IPayment payment1 = new CreditCardAdapter();
IPayment payment2 = new PaypalAdapter();

payment1.Initialize("User");
payment2.Initialize("User");

payment1.SendPayment(100);
payment2.SendPayment(100);

