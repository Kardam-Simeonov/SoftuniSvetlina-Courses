using System.Collections.Generic;
using System.Linq;

using GroceryStore;

using NUnit.Framework;

namespace BranchDecisionCoverage.Tests
{
    public class StoreBranchDecisionCoverage
    {
        private Store _store;

        [SetUp]
        public void SetUp()
        {
            _store = new Store();
        }

        [Test]
        public void Test_Store_IsEligibleForFigurine_StatementCoverage()
        {
            // Create a customer with an empty shopping bag
            var customer = new StoreCustomer();

            bool result = _store.IsEligibleForFigurine(customer);

            // The customer should get nothing, so the method should return false.
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_Store_IsEligibleForFigurine_BranchDecisionCoverage_Voucher()
        {
            // Create a customer with 10 items in the shopping bag
            var customer = new StoreCustomer
            {
                ShoppingBag = new List<string>
            {
                "Item1", "Item2", "Item3", "Item4", "Item5",
                "Item6", "Item7", "Item8", "Item9", "Item10"
            }
            };

            bool result = _store.IsEligibleForFigurine(customer);

            // The customer should get a discount voucher, so the method should return false.
            Assert.IsFalse(result);

            // Check that the DiscountVouchers property of the customer has been updated.
            Assert.AreEqual(1, customer.DiscountVouchers);
        }

        [Test]
        public void Test_Store_IsEligibleForFigurine_BranchDecisionCoverage()
        {
            // Create a customer with 15 items in the shopping bag
            var customer = new StoreCustomer
            {
                ShoppingBag = new List<string>
            {
                "Item1", "Item2", "Item3", "Item4", "Item5",
                "Item6", "Item7", "Item8", "Item9", "Item10",
                "Item11", "Item12", "Item13", "Item14", "Item15"
            }
            };

            bool result = _store.IsEligibleForFigurine(customer);

            // The customer should be eligible for a figurine, so the method should return true.
            Assert.IsTrue(result);
        }
    }
}
