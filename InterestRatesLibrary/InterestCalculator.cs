using InterestRatesLibrary.Factory;
using InterestRatesLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRatesLibrary
{
    public class InterestCalculator
    {
        IMockInterestRepository _mockInterestRepository;
        public InterestCalculator()
        {
            MockInterestRepositoryFactory mockInterestRepositoryFactory = new MockInterestRepositoryFactory();
            _mockInterestRepository = mockInterestRepositoryFactory.GetMockInterestRepository();
        }

        public decimal GetInterestRate(string balanceAsString)
        {
            try
            {
                decimal balance = ValidateInput(balanceAsString);
                decimal interestRate = 0.0m;
                if (balance > 0)
                {
                    interestRate = _mockInterestRepository.InterestRangeList.Where(i => balance >= i.LowerLimit && balance < i.UpperLimit).FirstOrDefault().Interest;
                }
                return interestRate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetInterest(string balanceAsString)
        {
            try
            {
                decimal balance = ValidateInput(balanceAsString);
                decimal interestRate = GetInterestRate(balanceAsString);
                decimal interest = 0.0m;
                if (balance > 0)
                {
                    interest = (balance * interestRate) / 100;
                }
                return interest.ToString("0.##");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ValidateInput(string balanceAsString)
        {
            decimal balance;
            if (!(Decimal.TryParse(balanceAsString, out balance)) || balance < 0)
            {
                throw new ArgumentNullException("Please enter valid input!");
            }
            return balance;
        }
    }
}
