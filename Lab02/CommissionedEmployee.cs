namespace Lab02
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public double CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }
        #endregion

        #region Constructor
        public CommissionEmployee(string id, string firstName, string lastName,
            double commissionPercentaje, decimal sales) :
            base(id, firstName, lastName)
        {
            CommissionPercentaje = commissionPercentaje;
            Sales = sales;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format(@"{0}
                % Commision...:  {1,18:P2}
                Sales.........: {2,18:C2}
                Salary........: {3,18:C2}",
                base.ToString(), CommissionPercentaje, Sales, CalculateSalary());
        }

        public override decimal CalculateSalary()
        {
            return (decimal)CommissionPercentaje * Sales;
        }
        #endregion
    }
}