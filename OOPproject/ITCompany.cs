using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class ITCompany
    {
        public static int CompanyCount { get; private set; }
        public string Name { get; set; }
        public double Budget { get;private set; }
        public string Location { get; set; }
        public bool IsOperational { get; set; }
        public List<Specialist> Specialists { get; set; }
        public University University { get; set; }
        public void HireSpecialist(Specialist specialist)
        {
            Specialists.Add(specialist);
            Console.WriteLine($"Hired {specialist} at {Name}");
        }
        public void AssignProject(string projectName)
        {
            Console.WriteLine($"Assigning project '{projectName}' to specialists at {Name}");
        }
        public void SponsorEvent(Event eventInfo)
        {
            Console.WriteLine($"{Name} is sponsoring the event: {eventInfo.Title}");
        }
        public ITCompany(): this("Default Company", 0.0, "Unknown", false)
        {
            
        }
        public ITCompany(string name, double budget, string location, bool isOperational)
        {
            Name = name;
            Budget = budget;
            Location = location;
            IsOperational = isOperational;
            Specialists = new List<Specialist>();
        }

        static ITCompany()
        {
            CompanyCount = 0;
        }

        public bool IsCompanySuccessful()
        {
            return IsOperational && Specialists.Count > 0 && University != null;
        }

        public bool IsCompanyInSameLocation(University university)
        {
            return Location == university.Location;
        }

        public bool IsCompanyBudgetSufficient(double requiredBudget)
        {
            return Budget >= requiredBudget;
        }

    }
}
