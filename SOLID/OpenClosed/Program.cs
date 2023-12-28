namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Bir nesne, ....gelişime.... açık ....değişime... kapalı olmalıdı
            Customer customer = new Customer() { CardType = new PremiumCard() };
            OrderManagement orderManagement = new OrderManagement() { Customer = customer };

            Console.WriteLine(orderManagement.GetDiscountedPrice(100));
        }
    }
}