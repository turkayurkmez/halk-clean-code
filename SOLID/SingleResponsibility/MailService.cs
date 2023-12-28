using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class MailService
    {
        public void Send(string to) => Console.WriteLine("gönderildi");
    }
}
