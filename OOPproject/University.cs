using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class University
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Ranking { get; set; }
        public double Tuition { get; set; }
        public bool IsPublic { get; set; }
        private List<string> Courses { get; set; } 
        public University()
        {
            Courses = new List<string>();
        }
        public University(string name, string location, int ranking, double tuition, bool isPublic)
        {
            Name = name;
            Location = location;
            Ranking = ranking;
            Tuition = tuition;
            IsPublic = isPublic;
            Courses = new List<string>();
        }
    }
}
