using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public int WorkedHours { get; set; }

        public decimal HourValue { get; set; }
        #endregion

        #region constructores
        public HourlyEmployee(string id, string firstName, string lastName, int workedHours, decimal hourValue) : base(id, firstName, lastName)
        {
            WorkedHours = workedHours;
            HourValue = hourValue;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return string.Format(@"{0}
                Worked hours..: {1,18:N2}
                Hour value....: {2,18:C2}
                Salary........: {3,18:C2}",
                base.ToString(), WorkedHours, HourValue, CalculateSalary());
        }

        public override decimal CalculateSalary()
        {
            return WorkedHours * HourValue;
        }
        #endregion
    }
}
