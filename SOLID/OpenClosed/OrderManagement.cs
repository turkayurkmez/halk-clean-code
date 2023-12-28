using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public interface ICardType
    {
        public double GetDiscountedPrice(double totalValue);

    }

    public class StandartCard : ICardType
    {
        public double GetDiscountedPrice(double totalValue)
        {
            return totalValue * .95;
        }
    }

    public class SilverCard : ICardType
    {
        public double GetDiscountedPrice(double totalValue)
        {
            return totalValue * .90;
        }
    }

    public class GoldCard : ICardType
    {
        public double GetDiscountedPrice(double totalValue)
        {
            return totalValue * .85;
        }
    }

    public class PremiumCard : ICardType
    {
        public double GetDiscountedPrice(double totalValue)
        {
            return totalValue * .80;
        }
    }

    public class Customer
    {
        public ICardType CardType { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public double GetDiscountedPrice(double totalValue)
        {
            //switch (Customer.CardType)
            //{
            //    case CardType.Standard:
            //        return totalValue * .95;
            //    case CardType.Silver:
            //        return totalValue * .90;

            //    case CardType.Gold:
            //        return totalValue * .85;


            //    default:
            //        return totalValue;

            //}

            return Customer.CardType.GetDiscountedPrice(totalValue);

        }
    }
}
