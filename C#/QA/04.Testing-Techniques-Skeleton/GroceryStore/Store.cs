namespace GroceryStore
{
    public class Store
    {
        public bool IsEligibleForFigurine(StoreCustomer customer)
        {
            // Check the items that the customer is going to buy
            // if they are more than 15 the customer receives a figurine
            if (customer.ShoppingBag.Count >= 15)
            {
                return true;
            }

            // if they are between 10 and 14 the customer gets a discount voucher
            if (customer.ShoppingBag.Count >= 10 && customer.ShoppingBag.Count < 15)
            {
                customer.DiscountVouchers++;
            }

            // else the customer gets nothing
            return false;
        }
    }
}
