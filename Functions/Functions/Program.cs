namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. 1-100 arasında rastgele bir sayı seç.
             * 2. Kullanıcıdan tahmin iste
             * 3. Tahmin ile seçilen sayıyı karşılaştır
             *       -- sonuca göre yönlendir.
             * 4. Bilene dek 2. adıma git.
             */
            var targetNumber = getRandomNumber(1, 100);
            var output = string.Empty;

            do
            {
                var suggested = getSuggestedNumberFromUser();
                output = compare(targetNumber, suggested);
                Console.WriteLine(output);

            } while (output != CompareResult.Equal);
        }

        /// <summary>
        /// Rastgele sayı getirir.
        /// </summary>
        /// <param name="minimum">Sayı aralığının alt sınırı</param>
        /// <param name="maximum">Sayı aralığının üst sınırı</param>
        /// <returns>min ile max arasında bir sayı</returns>
        static int getRandomNumber(int minimum, int maximum) => new Random().Next(minimum, maximum);
        static int getSuggestedNumberFromUser()
        {
            Console.WriteLine("Lütfen sayıyı tahmin edin");
            return int.Parse(Console.ReadLine());
        }


        static string compare(int target, int suggest)
        {
            if (target > suggest)
            {
                return CompareResult.Up;
            }
            else if (target < suggest)
            {
                return CompareResult.Down;
            }

            return CompareResult.Equal;
        }


    }

    public class CompareResult
    {
        public const string Up = "Yukarı";
        public const string Down = "Aşağı";
        public const string Equal = "Bildiniz";

    }
}