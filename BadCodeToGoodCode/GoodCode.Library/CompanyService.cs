using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCode.Library
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                new(){ Name="Acme", HourlyPayment=150},
                new(){ Name="Abc", HourlyPayment=125},

            };
        }
    }
}
