using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCode.Library
{
    public class EmailService
    {
        private readonly List<TimeSheetEntry> timeSheetEntries;
        private readonly CompanyService companyService;

        public EmailService(List<TimeSheetEntry> timeSheetEntries, CompanyService companyService)
        {
            this.timeSheetEntries = timeSheetEntries;
            this.companyService = companyService;
        }

        public void SendMail()
        {
            var companies = companyService.GetCompanies();


            sendEmail(companies, timeSheetEntries);
        }

        private static void sendEmail(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
        {


            companies.ForEach(company =>
            {
                double totalHoursWorked = getTotalHours(timeSheetEntries, company);
                Console.WriteLine($"Simulating Sending email to {company.Name}");
                Console.WriteLine("Your bill is $" + (totalHoursWorked * company.HourlyPayment) + " for the hours worked.");
            });
        }

        private static double getTotalHours(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            var totalHoursWorked = 0.0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(company.Name.ToLower()))
                {
                    totalHoursWorked += timeSheetEntries[i].HoursWorked;
                }
            }

            //alternatif:
            //return timeSheetEntries.Where(ts => ts.WorkDone.ToLower().Contains(company.Name)).Sum(x => x.HoursWorked);

            return totalHoursWorked;
        }
    }
}
