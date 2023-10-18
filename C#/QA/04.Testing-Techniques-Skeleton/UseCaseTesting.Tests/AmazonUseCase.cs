using AmazonnFresh;

using NUnit.Framework;

namespace UseCaseTesting.Tests
{
    public class AmazonUseCase
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_NoCoupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_NoCoupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_Coupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_Coupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_NoCoupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_NoCoupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_Coupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_Coupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_NoCoupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_NoCoupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_Coupon_FigurineTicket()
        {

        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_Coupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_NoCoupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_NoCoupon_Figurine()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_Coupon_FigurineTicket()
        {
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_Coupon_Figurine()
        {
        }

        private decimal GetExpectedMoneyLeft(AmazonCustomer customer, bool isNewCustomer)
        {
            decimal total = 0;

            foreach (Product product in customer.Cart.Cart)
            {
                total += product.Price;
            }

            int discount =
                AmazonConstraints.AmazonBrandedDiscount * customer.AmazonBrandedItemsToBuy
                + (customer.HasCoupon ? AmazonConstraints.CouponDiscount : 0)
                + (isNewCustomer ? AmazonConstraints.NewCustomerDiscount : 0);
            total *= (100.00m - discount) / 100;

            return this.startingBalance - total;
        }
    }
}
