using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class StartupProject : IFundable
    {

        public string Name { get; set; }
        public string Industry { get; set; }
        public double Funding { get; set; }
        public int Employees { get; set; }
        public bool IsSuccessful { get; set; }
        private List<string> Technologies { get; set; }
        public StartupProject()
        {
            Technologies = new List<string>();
        }
        public StartupProject(string name, string industry, double funding, int employees, bool isSuccessful)
            {
                Name = name;
                Industry = industry;
                Funding = funding;
                Employees = employees;
                IsSuccessful = isSuccessful;
                Technologies = new List<string>();
        }
        public void ApplyForFunding(double amount)
        {
            Console.WriteLine($"{Name} is applying for funding of {amount:C}");
        }
    }
}
