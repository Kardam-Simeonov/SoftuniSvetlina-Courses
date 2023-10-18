namespace AmazonnFresh
{
    public class ShoppingCart
    {
        public ShoppingCart(int products, int brandedProducts)
        {
            this.Cart = new List<Product>();
            this.AddToCart(products, brandedProducts);
        }

        public List<Product> Cart { get; }

        private void AddToCart(int boardsCount, int dartsCount)
        {
            DartsBoard dartsBoard = new DartsBoard();
            for (int i = 0; i < boardsCount; i++)
            {
                this.Cart.Add(dartsBoard);
            }

            AmazonDarts amazonDarts = new AmazonDarts();
            for (int i = 0; i < dartsCount; i++)
            {
                this.Cart.Add(amazonDarts);
            }
        }
    }
}
