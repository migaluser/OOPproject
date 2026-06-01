using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class ITCluster
    {
        public List<ITCompany> ITCompanies { get; set; }
        public List<University> Universities { get; set; }
        public Event AnnualHackathon { get; set; }
        public void OrganizeConference()
        {
            Console.WriteLine("Organizing IT Conference...");
        }
        public void OrganizeHackathon()
        {
            Console.WriteLine("Organizing Annual Hackathon...");
        }
        public void CollaborateWithUniversities()
        {
            Console.WriteLine("Collaborating with Universities...");
        }
        public ITCluster()
        {
            ITCompanies = new List<ITCompany>();
            Universities = new List<University>();
            AnnualHackathon = new Event { Title = "Annual Hackathon" };
        }
        public ITCluster(List<ITCompany> itCompanies, List<University> universities, Event annualHackathon)
        {
            ITCompanies = itCompanies;
            Universities = universities;
            AnnualHackathon = annualHackathon;
        }
        public void OrganizeOlimpiad( University hostUniversity, ITCompany sponsor, double prizeFund)
        {
            sponsor.ProvideFinancialSupport(hostUniversity, prizeFund);
            Console.WriteLine($"Organizing IT Olympiad at {hostUniversity.Name} sponsored by {sponsor.Name} with a prize fund of {prizeFund}");
        }
    }
}
