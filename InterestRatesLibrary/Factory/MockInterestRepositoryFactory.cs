using InterestRatesLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRatesLibrary.Factory
{
    public class MockInterestRepositoryFactory
    {
        public IMockInterestRepository GetMockInterestRepository()
        {
            IMockInterestRepository mockInterestRepository = new MockInterestRepository();
            return mockInterestRepository;
        }
    }
}
