namespace Lab02
{
    public class SalariedEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion

        #region Constructor
        public SalariedEmployee(string id, string firstName, string lastName, decimal salary) :
            base(id, firstName, lastName)
        {
            Salary = salary;
        }
        #endregion

        #region Methods
        public override decimal CalculateSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
                Salary........: {1,18:C2}",
                base.ToString(), CalculateSalary());
        }
        #endregion
    }
}