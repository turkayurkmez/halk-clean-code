using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Report
    {
        private readonly ISender sender;
        public Report(ISender mailSender)
        {
            sender = mailSender;
        }
        public void SendNotification(string to)
        {

            sender.Send(to);
        }
    }


    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("WS ile gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram ile gönderildi");

        }
    }

}
