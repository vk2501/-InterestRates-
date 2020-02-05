using InterestRatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRatesPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            do
            {
                Console.Write("Please enter the balance: ");
                string input = Console.ReadLine();
                InterestCalculator interestCalculator = new InterestCalculator();
                decimal interestRate = interestCalculator.GetInterestRate(input);
                string interest = interestCalculator.GetInterest(input);
                Console.WriteLine("================================================================");
                Console.WriteLine($"You have earned £{interest}p interest @ £{interestRate}p interest rate");
                Console.WriteLine("================================================================");
                Console.Write("Do you want to try with different balance? (y/n): ");
                repeat = Console.ReadLine();
                Console.WriteLine("");
            } while (repeat.ToUpper() == "Y");
        }
    }
}
