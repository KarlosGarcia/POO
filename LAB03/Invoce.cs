namespace Lab03
{
    public class Invoice : IPay
    {
        #region Properties
        public string Id { get; set; }

        public string Description { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }
        #endregion

        #region Methods
        public decimal GetAmountToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return string.Format(@"{0} {1}
                Quantity.......: {2,18:N2}
                Price..........: {3,18:C2}
                To Pay.........: {4,18:C2}", Id, Description, Quantity, Price, GetAmountToPay());
        }
        #endregion
    }
}