namespace LiskovSubstution
{
    internal class Program
    {
        /*
         * Miras alan class, 
         * Miras veren class'dan
         * gelen işlevlerin davranışını DEĞİŞTİRMEMELİ
         */
        static void Main(string[] args)
        {
            //Square square = new Square() { Width = 5 };
            //Rectangle rectangle = new Rectangle() { Height = 3, Width = 5 };

            //Console.WriteLine($"kare: {square.GetArea()}");
            //Console.WriteLine($"dörtgen: {rectangle.GetArea()}");

            //var rect = new Geometry().GetRectangle();
            //rect.Width = 10;
            //rect.Height = 4;

            Geometry geometry = new Geometry();
            var square = geometry.GetRectangle(5);
            var rect = geometry.GetRectangle(4, 2);

            Console.WriteLine($"kare {square.GetArea()}");
            Console.WriteLine($"dörtgen {rect.GetArea()}");


            //Console.WriteLine($"benim beklediğim 40. son hesaplanan: {rect.GetArea()}");

        }
    }
}