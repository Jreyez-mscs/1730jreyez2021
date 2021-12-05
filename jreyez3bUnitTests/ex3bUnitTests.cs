using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using jreyez3b1;

namespace jreyez3bUnitTests
{
    [TestClass]
    public class ex3bUnitTests
    {
        [TestMethod]
        public void GetDiscountPercent_Low()
        {
            Assert.AreEqual(0.1m, ex3bCalculations.GetDiscountPercent(499m));
        }
        [TestMethod]
        public void GetDiscountPercent_High()
        {
            Assert.AreEqual(0.2m, ex3bCalculations.GetDiscountPercent(500m));
        }
        //[TestMethod]
        //public void GetDiscountPercent_Out_Low()
        //{
        //    decimal discountPercent = 0m;
        //    ex3bCalculations.GetDiscountPercent(499m, out discountPercent);
        //    Assert.AreEqual(0.1m, discountPercent);
        //}
        //[TestMethod]
        //public void GetDiscountPercent_Out_High()
        //{
        //    decimal discountPercent = 0m;
        //    ex3bCalculations.GetDiscountPercent(500m, out discountPercent);
        //    Assert.AreEqual(0.2m, discountPercent);
        //}
        [TestMethod]
        public void CalcFutureValue_12Mo100US()
        {
            Assert.AreEqual(1231.66m,
                Decimal.Round(ex3bCalculations.CalculateFutureValue(100m, 0.004m, 12), 2));
        }
        [TestMethod]
        public void CalcFutureValue_120Mo20US()
        {
            Assert.AreEqual(2892.37m,
                Decimal.Round(ex3bCalculations.CalculateFutureValue(20m, 0.003m, 120), 2));
        }
        [TestMethod]
        public void CalcFutureValue_Ref_12Mo100US()
        {
            decimal futureValue = 0m;
            ex3bCalculations.CalculateFutureValue(100m, 0.004m, 12, ref futureValue);
            Assert.AreEqual(1231.66m, Decimal.Round(futureValue, 2));
        }
        [TestMethod]
        public void CalcFutureValue_Ref_120Mo20US()
        {
            decimal futureValue = 0m;
            ex3bCalculations.CalculateFutureValue(20m, 0.003m, 120, ref futureValue);
            Assert.AreEqual(2892.37m, Decimal.Round(futureValue, 2));
        }
        [TestMethod]
        public void FahrenheitToCelsius212()
        {
            Assert.AreEqual(100.0,
                Math.Round(ex3bCalculations.FahrenheitToCelsius(212.0), 1));
        }
        [TestMethod]
        public void FahrenheitToCelsius32()
        {
            Assert.AreEqual(0.0,
                Math.Round(ex3bCalculations.FahrenheitToCelsius(32.0), 1));
            }
        //[TestMethod]
        //public void CelsiusToFahrenheit0()
        //{
        //    double fahrenheit = 0.0;
        //    ex3bCalculations.CelsiusToFahrenheit(0, out fahrenheit);
        //    Assert.AreEqual(32.0, Math.Round(fahrenheit, 1));
        //}
        //[TestMethod]
        //public void CelsiusToFahrenheit100()
        //{
        //    double fahrenheit = 0.0;
        //    ex3bCalculations.CelsiusToFahrenheit(100, out fahrenheit);
        //    Assert.AreEqual(212.0, Math.Round(fahrenheit, 1));
        //}
        [TestMethod]
        public void GrossPay_40_10()
        {
            Assert.AreEqual(400m,
                Decimal.Round(ex3bCalculations.GrossPay(40m, 10m), 2));
        }
        [TestMethod]
        public void GrossPay_50_10()
        {
            Assert.AreEqual(550m,
                Decimal.Round(ex3bCalculations.GrossPay(50m, 10m), 2));
        }
        [TestMethod]
        public void TotalHours()
        {
            Assert.AreEqual(10m,
                Decimal.Round(ex3bCalculations.TotalHours("1.1 2.2 3.3 3.4 "), 2));
        }
        [TestMethod]
        public void GrossPay_String_10()
        {
            Assert.AreEqual(100m,
                Decimal.Round(ex3bCalculations.GrossPay("1.1 2.2 3.3 3.4 ", 10m), 2));
        }
    }
}
