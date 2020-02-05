using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRatesLibrary.Model
{
    public class InterestRate
    {
        public decimal LowerLimit { get; set; }
        public decimal UpperLimit { get; set; }
        public decimal Interest { get; set; }
    }
}
