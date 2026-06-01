using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class Ministry
    {
       public string Name { get; set; }
       public string Location { get; set; }
       public int Employees { get; set; }
       public double Budget { get; set; }
       public bool IsGovernment { get; set; }
            private List<string> Departments { get; set; }
            private Ministry()
            {
                Departments = new List<string>();
            }
            private Ministry(string name, string location, int employees, double budget, bool isGovernment)
            {
                Name = name;
                Location = location;
                Employees = employees;
                Budget = budget;
                IsGovernment = isGovernment;
                Departments = new List<string>();
            }
        public static Ministry CreateMinistry(string name, string location, int employees, double budget, bool isGovernment)
        {
            return new Ministry(name, location, employees, budget, isGovernment);
        }
    }
}
