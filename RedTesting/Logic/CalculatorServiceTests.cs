using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit.Sdk;

namespace Calculator.Data.Tests
{
    [TestClass()]
    public class CalculatorServiceTests
    {
        [TestMethod()]
        public void GetCalculatedResultTest() // Check PA and PB field to see of the input will equal correct amount...
        {
            ProbabilityData calculator = new ProbabilityData();
            
            Assert.AreEqual(calculator.PA = 0.5, calculator.PB = 0.5, calculator.currentCount = 0.75);
        }

        [TestMethod()]
        public void DateInputCheckTest() //Date test
        {
            ProbabilityData data = new ProbabilityData();

            DateTime currentDate = DateTime.Now;

            Assert.AreEqual(currentDate.Date, data.DateOfCalculation.Date);
        }
    }
}