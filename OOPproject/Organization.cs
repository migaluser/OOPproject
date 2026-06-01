using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public abstract class Organization
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Employees { get; set; }
        public double Budget { get; set; }
        public bool IsNonProfit { get; set; }
        protected Organization()
        {
        }
        protected Organization(string name, string location, int employees, double budget, bool isNonProfit)
        {
            Name = name;
            Location = location;
            Employees = employees;
            Budget = budget;
            IsNonProfit = isNonProfit;
        }
        public abstract void ConductActivity(string activity);
    }
}
