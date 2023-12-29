using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCode.Library
{
    public class PaymentCalculator
    {
        public double GetExtraPayment(double totalHoursWorked, int maxHourInAWeek = 40, double extra = 15, double standard = 10)
        {
            if (totalHoursWorked > maxHourInAWeek)
            {
                var paymentForExtraTime = (totalHoursWorked - maxHourInAWeek) * extra;
                var standardPayment = maxHourInAWeek * standard;
                return paymentForExtraTime + standardPayment;
            }
            else
            {

                return totalHoursWorked * standard;
            }
        }
    }
}
