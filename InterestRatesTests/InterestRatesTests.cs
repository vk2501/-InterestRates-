using System;
using InterestRatesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterestRatesTests
{
    [TestClass]
    public class InterestRatesTests
    {
        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("asdsajhs")]
        [DataRow("999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999")]
        [DataRow("-10.00")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void InterestRates_WhenBalanceIsInvalid_ThrowNullArgumentException(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
        }

        [DataTestMethod]
        [DataRow("0.00")]
        public void InterestRates_WhenBalanceIsZero_Return0Percent(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
            // Assert
            Assert.AreEqual(0.00m, actual);
        }

        [DataTestMethod]
        [DataRow ("0.01")]
        [DataRow("100.00")]
        [DataRow("999.99")]
        public void InterestRates_WhenBalanaceIsLessThan1000_Return1Percent(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
            // Assert
            Assert.AreEqual(1.00m, actual);
        }

        [DataTestMethod]
        [DataRow("1000.00")]
        [DataRow("2500.00")]
        [DataRow("4999.99")]
        public void InterestRates_WhenBalanceIsBetween1000And5000_Return1point5Percent(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
            // Assert
            Assert.AreEqual(1.50m, actual);
        }

        [DataTestMethod]
        [DataRow("5000.00")]
        [DataRow("5500.00")]
        [DataRow("9999.99")]
        public void InterestRates_WhenBalanceIsBetween5000And10000_Return2Percent(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
            // Assert
            Assert.AreEqual(2.00m, actual);
        }

        [DataTestMethod]
        [DataRow("10000.00")]
        [DataRow("25000.00")]
        [DataRow("49999.99")]
        public void InterestRates_WhenBalanceIsBetween10000And50000_Return2point5Percent(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
            // Assert
            Assert.AreEqual(2.50m, actual);
        }

        [DataTestMethod]
        [DataRow("50000.00")]
        [DataRow("100000.00")]
        [DataRow("999999999999.99")]
        public void InterestRates_WhenBalanceIsAbove50000_Return2point5Percent(string input)
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            decimal actual = interestRates.GetInterestRate(input);
            // Assert
            Assert.AreEqual(3.00m, actual);
        }

        [TestMethod]
        public void InterestRates_WhenInputedBalanace_ReturnCalculatedInterest()
        {
            // Arange
            InterestCalculator interestRates = new InterestCalculator();
            // Act
            string actual = interestRates.GetInterest("1001");
            // Assert
            Assert.AreEqual("15.02", actual);
        }
    }
}
