namespace Lab02
{
    public abstract class Employee
    {
        #region Properties
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        #endregion

        #region Constructor
        public Employee(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, FirstName, LastName);
        }

        public abstract decimal CalculateSalary();
        #endregion
    }
}
