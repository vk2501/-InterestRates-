using InterestRatesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRatesLibrary.Repository
{
    public class MockInterestRepository : IMockInterestRepository
    {
        List<InterestRate> _interestRangeList = new List<InterestRate>();

        public MockInterestRepository()
        {
            BuildInterestRepository();
        }
        public List<InterestRate> InterestRangeList
        {
            get
            { 
                return _interestRangeList; 
            }
        }

        private void BuildInterestRepository()
        {
            _interestRangeList.AddRange(new List<InterestRate>
            {
                new InterestRate { LowerLimit = 0.00m, UpperLimit = 1000.00m, Interest = 1.0m },
                new InterestRate { LowerLimit = 1000.00m, UpperLimit = 5000.00m, Interest = 1.5m },
                new InterestRate { LowerLimit = 5000.00m, UpperLimit = 10000.00m, Interest = 2.0m },
                new InterestRate { LowerLimit = 10000.00m, UpperLimit = 50000.00m, Interest = 2.5m },
                new InterestRate { LowerLimit = 1000.00m, UpperLimit = Decimal.MaxValue, Interest = 3.0m }
             });
        }
    }
}
