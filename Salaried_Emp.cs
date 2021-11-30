using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Salaried_Emp : Employee
    {
        public Salaried_Emp()
        {
            throw new System.NotImplementedException();
        }

        public int Payrate
        {
            get => default(int);
            set
            {
            }
        }

        public void DifferentialPay()
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
            }

    }
}