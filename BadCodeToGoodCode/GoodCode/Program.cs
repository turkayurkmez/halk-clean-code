using GoodCode.Library;

namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSheetEntries = getEntriesFromUser();

            CompanyService companyService = new CompanyService();
            var mailService = new EmailService(timeSheetEntries, companyService);
            mailService.SendMail();
            double totalHoursWorked = timeSheetEntries.Sum(x => x.HoursWorked);
            var extraPayment = new PaymentCalculator().GetExtraPayment(totalHoursWorked);
            Console.WriteLine($"You will get paid ${extraPayment} for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        private static List<TimeSheetEntry> getEntriesFromUser()
        {

            string answer;
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            do
            {
                Console.Write("Enter what you did: ");
                string workDescription = Console.ReadLine();
                double timeForWork = getTimeForWorkFromUser();

                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDescription
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");

                answer = Console.ReadLine();



            } while (answer.ToLower() == "yes");

            return timeSheetEntries;
        }

        private static double getTimeForWorkFromUser()
        {
            double timeForWork;
            string rawTimeWorked;
            do
            {
                Console.WriteLine("Please use true format");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();

            } while (!double.TryParse(rawTimeWorked, out timeForWork));
            return timeForWork;
        }
    }


}