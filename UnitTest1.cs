using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void CalculatePay()
            {
                if (Hours_worked > base_hours)
                {
                    basepay = Hourly_rate * base_hours;
                    Calculate_overtime = Hours_worked - base_hours;
                    overtimePay = overtimehours * HourlyPay * overtime_rate;
                    unitpay = 3 * units_produced;
                    grosspay = basepay + overtimePay + unitPay;

                }
        }
    }
}
