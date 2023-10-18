using System;
using System.Collections.Generic;

namespace AmazonnFresh
{
    public class AmazonStore
    {
        private readonly List<AmazonCustomer> customers;

        public AmazonStore()
        {
            this.customers = new List<AmazonCustomer>();
        }

        public void EnterStore(AmazonCustomer customer)
        {
            // Initialize a discount variable
            int discount = 0;

            // Check if the customer exists and if he does not
            // add him and give him a 10% discount
            if (!this.CheckForExistingCustomer(customer))
            {
                this.AddCustomer(customer);
                discount += AmazonConstraints.NewCustomerDiscount;
            }

            // Apply the amazon discount (if they have amazonn branded items)
            discount += AmazonConstraints.AmazonBrandedDiscount * customer.AmazonBrandedItemsToBuy;

            // Apply discount if the customer has a coupon
            if (customer.HasCoupon)
            {
                discount += AmazonConstraints.CouponDiscount;
            }

            // Check if the customer is eligible for a figurine
            if (this.CanReceiveFigurine(customer.ItemsToBuy + customer.AmazonBrandedItemsToBuy))
            {
                customer.Figurines++;
            }
            // if not just give him a ticket
            else
            {
                customer.FigurineTickets++;
            }

            // Calculate and deduct the total payment amount from the customers credit card
            customer.CashOnCard -= this.GetTotalPayment(customer.Cart, discount);
        }

        public void AddCustomer(AmazonCustomer customer)
            => this.customers.Add(customer);

        private bool CanReceiveFigurine(int quantity)
            => quantity >= 15;

        private bool CheckForExistingCustomer(AmazonCustomer customer)
            => this.customers.Contains(customer);

        private decimal GetTotalPayment(ShoppingCart cart, int discount)
        {
            decimal total = 0;

            foreach (Product product in cart.Cart)
            {
                total += product.Price;
            }

            total *= (100.00m - discount) / 100;

            return total;
        }
    }
}
