using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class Specialist
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public bool IsEmployed { get; set; }
        private List<string> Skills { get; set; }
        public Specialist()
        {
            Skills = new List<string>();
        }
        public Specialist(string name, string position, double salary, string department, bool isEmployed)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Department = department;
            IsEmployed = isEmployed;
            Skills = new List<string>();
        }
        public Specialist(Specialist other)
        {
            Name = other.Name;
            Position = other.Position;
            Salary = other.Salary;
            Department = other.Department;
            IsEmployed = other.IsEmployed;
            Skills = new List<string>(other.Skills);
        }
    }
}
