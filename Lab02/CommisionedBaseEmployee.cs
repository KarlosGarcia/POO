using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class CommisionedBaseEmployee : CommissionEmployee
    {
        public decimal SalaryBase { get; set; }
        public CommisionedBaseEmployee(string id, string firstName, string lastName, double commissionPercentaje, decimal sales, decimal salaryBase) : 
            base(id, firstName, lastName, commissionPercentaje, sales)
        {
            SalaryBase = salaryBase;
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + SalaryBase;
        }

        public override string ToString()
        {
            return string.Format(@"{0} {1} {2}
                % Commision...:  {3,18:P2}
                Base..........: {4,18:C2}
                Sales.........: {5,18:C2}
                Salary........: {6,18:C2}",
                Id, FirstName, LastName, CommissionPercentaje, SalaryBase, Sales, CalculateSalary());
        }
    }
}
