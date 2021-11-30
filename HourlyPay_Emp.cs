using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class HourlyPay_Emp : Employee
    {
        public HourlyPay_Emp()
        {
            throw new System.NotImplementedException();
        }

        public int Hourly_rate
        {
            get => default(int);
            set
            {
            }
        }

        public int Hours_worked
        {
            get => default(int);
            set
            {
            }
        }

        public void Calculate_overtime()
        {
            throw new System.NotImplementedException();
        }

        public void CalculatePay()
        {
            throw new System.NotImplementedException();

            if (Hours_worked > base_hours)
            {
                basepay = Hourly_rate * base_hours;
                Calculate_overtime = Hours_worked - base_hours;
                overtimePay = overtimehours * HourlyPay * overtime_rate;
                unitpay = 3 * units_produced;
                grosspay = basepay + overtimePay + unitPay;
            }

        public void HourlyPay()
        {
            throw new System.NotImplementedException();
        }
    }
}