using System;
using jreyez2h1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jreyez2h1.Tests
{
    [TestClass]
    public class Ex2hhDateTimeUnitTests
    {
        [TestMethod]
        public void DateCalc06_YearNumFmtExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc06("", "01", "01"));
        }
        [TestMethod]
        public void DateCalc06_MonthNumFmtExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc06("2000", "", "01"));
        }
        [TestMethod]
        public void DateCalc06_DayNumFmtExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc06("2000", "01", ""));
        }
        [TestMethod]
        public void DateCalc06_DateArgRangeExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc06("2000", "13", "01"));
        }
        [TestMethod]
        public void DateCalc06_ValidDateCtor()
        {
            Assert.AreEqual("1/1/2000", Ex2hhCalculations.DateCalc06("2000", "1", "1"));
        }
        [TestMethod]
        public void DateCalc07_DateParseExcept()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc07("aaa"));
        }
        [TestMethod]
        public void DateCalc07_ValidDateParse()
        {
            Assert.AreEqual("1/1/2000", Ex2hhCalculations.DateCalc07("1/1/2000"));
        }
        [TestMethod]
        public void DateCalc08_DateTryParseErr()
        {
            Assert.AreEqual("1/1/0001", Ex2hhCalculations.DateCalc08("aaa"));
        }
        [TestMethod]
        public void DateCalc08_ValidDateTryParse()
        {
            Assert.AreEqual("1/1/2000", Ex2hhCalculations.DateCalc08("1/1/2000"));
        }
        [TestMethod]
        public void DateCalc09_DateParseExceptA()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc09("aaa", "1/1/2000"));
        }
        public void DateCalc09_DateParseExceptB()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc09("1/1/2000", "aaa"));
        }
        [TestMethod]
        public void DateCalc09_ValidDates()
        {
            Assert.AreEqual("31 days", Ex2hhCalculations.DateCalc09("2/1/2000", "1/1/2000"));
        }
        [TestMethod]
        public void DateCalc10_DateParseExceptA()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc10("aaa", "1/1/2000"));
        }
        public void DateCalc10_DateParseExceptB()
        {
            Assert.AreEqual("Invalid input", Ex2hhCalculations.DateCalc10("1/1/2000", "aaa"));
        }
        [TestMethod]
        public void DateCalc10_31DaysPastDue()
        {
            Assert.AreEqual("31 days past due", Ex2hhCalculations.DateCalc10("2/1/2000", "1/1/2000"));
        }
        [TestMethod]
        public void DateCalc10_OnTime()
        {
            Assert.AreEqual("On time", Ex2hhCalculations.DateCalc10("1/1/2000", "1/1/2000"));
        }

    }
}
