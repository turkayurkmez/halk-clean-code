using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        public int CreateProduct(string name, decimal price)
        {
            //işiniz bitti.
            //sendMailToAdmin("admin@admin.com");
            MailService mailService = new MailService();
            mailService.Send("admin");
            return 1;
        }
    }
}
