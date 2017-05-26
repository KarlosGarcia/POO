namespace Lab03
{
    public abstract class Employee : IPay
    {
        #region Properties
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, FirstName, LastName);
        }

        public abstract decimal GetAmountToPay();
        #endregion
    }
}
