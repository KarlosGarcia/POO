using Lab03;
using System;


namespace LAB03
{
    public class SalariedEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetAmountToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
                Salary........: {1,18:C2}",
                base.ToString(), GetAmountToPay());
        }
    }
}
