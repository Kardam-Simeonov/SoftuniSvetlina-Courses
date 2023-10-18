using System.Collections.Generic;

namespace GroceryStore
{
    public class StoreCustomer
    {
        public StoreCustomer()
        {
            this.ShoppingBag = new List<string>();
        }

        public List<string> ShoppingBag { get; set; }

        public int DiscountVouchers { get; set; }
    }
}
