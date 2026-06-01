using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public interface IFundable
    {
        double Funding { get; set; }
        void ApplyForFunding(double amount);
    }
}
