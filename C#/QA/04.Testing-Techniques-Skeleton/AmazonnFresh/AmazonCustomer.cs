namespace AmazonnFresh
{
    public class AmazonCustomer
    {
        public AmazonCustomer(int itemsToBuy, int amazonBrandedItemsToBuy, 
            bool hasCoupon, decimal cashOnCard)
        {
            this.ItemsToBuy = itemsToBuy;
            this.AmazonBrandedItemsToBuy = amazonBrandedItemsToBuy;
            this.HasCoupon = hasCoupon;
            this.CashOnCard = cashOnCard;

            this.Cart = new ShoppingCart(this.ItemsToBuy, this.AmazonBrandedItemsToBuy);
        }

        public int ItemsToBuy { get; }

        public int AmazonBrandedItemsToBuy { get; }

        public bool HasCoupon { get; }

        public decimal CashOnCard { get; set; }

        public int Figurines { get; set; }

        public int FigurineTickets { get; set; }

        public ShoppingCart Cart { get; }
    }
}
