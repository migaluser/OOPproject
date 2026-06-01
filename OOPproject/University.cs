using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class University : Organization, IFundable
    {
        public double Funding { get; set; }
        public int Ranking { get;private set; }
        public double Tuition { get; set; }
        public bool IsPublic { get; set; }

        private List<string> Courses { get; set; } 
        public University()
        {
            Courses = new List<string>();
        }
        public University(string name, string location, int ranking, double tuition, bool isPublic) : base(name, location, 0, 0.0, false)
        {
            Ranking = ranking;
            Tuition = tuition;
            IsPublic = isPublic;
            Courses = new List<string>();
        }
        public bool IsUniversityHighlyRanked()
        {
            return Ranking > 0 && Ranking <= 100;
        }
        public void ModernizeCurriculum(string newCourses)
        {
            Courses.Add(newCourses);
            Console.WriteLine($"Curriculum at {Name} has been modernized with new course: {newCourses}");
        }
        public override void ConductActivity(string activity)
        {
            Console.WriteLine($"{Name} is conducting the activity: {activity}");
        }
        public void ApplyForFunding(double amount)
        {
            Console.WriteLine($"{Name} is applying for funding of {amount:C}");
        }
    }
}
