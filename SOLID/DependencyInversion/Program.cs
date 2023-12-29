// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

MailSender mailSender = new MailSender();
WhatsAppSender whatsSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();

Report report1 = new Report(mailSender);
Report report2 = new Report(whatsSender);
Report report3 = new Report(telegramSender);

report3.SendNotification("user");