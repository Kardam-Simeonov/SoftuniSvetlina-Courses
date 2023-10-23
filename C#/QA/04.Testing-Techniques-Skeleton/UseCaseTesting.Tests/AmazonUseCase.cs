using AmazonnFresh;

using NUnit.Framework;

namespace UseCaseTesting.Tests
{
    public class AmazonUseCase
    {
        private AmazonStore store;
        private decimal startingBalance;

        [SetUp]
        public void SetUp()
        {
            this.store = new AmazonStore();
            this.startingBalance = 1500;
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

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_NoCoupon_FigurineTicket()
        {
            //Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 0, false, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_NoCoupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 0, false, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_Coupon_FigurineTicket()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 0, true, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_NoAmazon_Coupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 0, true, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_NoCoupon_FigurineTicket()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 5, false, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_NoCoupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 5, false, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_Coupon_FigurineTicket()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 5, true, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_NewCustomer_Amazon_Coupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 5, true, this.startingBalance);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, true);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_NoCoupon_FigurineTicket()
        {
            //Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 0, false, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_NoCoupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 0, false, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_Coupon_FigurineTicket()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 0, true, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_NoAmazon_Coupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 0, true, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_NoCoupon_FigurineTicket()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 5, false, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_NoCoupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 5, false, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_Coupon_FigurineTicket()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(5, 5, true, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(0, customer.Figurines);
            Assert.AreEqual(1, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }

        [Test]
        public void Test_AmazonnStore_EnterStore_ExistingCustomer_Amazon_Coupon_Figurine()
        {
            // Arrange
            AmazonCustomer customer = new AmazonCustomer(20, 5, true, this.startingBalance);
            this.store.AddCustomer(customer);

            // Act
            this.store.EnterStore(customer);

            // Assert
            decimal expected = this.GetExpectedMoneyLeft(customer, false);
            Assert.AreEqual(1, customer.Figurines);
            Assert.AreEqual(0, customer.FigurineTickets);
            Assert.AreEqual(expected, customer.CashOnCard);
        }
    }
}
