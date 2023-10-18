namespace AmazonnFresh
{
    public abstract class Product
    {
        public Product(decimal price, bool isAmazonBranded)
        {
            this.Price = price;
            this.IsAmazonBranded = isAmazonBranded;
        }

        public decimal Price { get; private set; }

        public bool IsAmazonBranded { get; private set; }
    }
}
