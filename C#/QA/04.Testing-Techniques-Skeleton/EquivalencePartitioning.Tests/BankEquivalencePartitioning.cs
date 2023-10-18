using CustomerBank;
using NUnit.Framework;

namespace EquivalencePartitioning.Tests
{
    public class BankEquivalencePartitioning
    {
        private Bank bank;
        private BankCustomer receiver;

        [SetUp]
        public void SetUp()
        {
            bank = new Bank();
            receiver = new BankCustomer();
        }

        [Test]
        public void Test_Bank_TransferPayment_PartitionOverMaximum()
        {
            decimal amount = 5000.00m;
            string result = bank.TransferPayment(receiver, amount);
            Assert.AreEqual("Cannot transfer more than 4500.00 euros!", result);
        }

        [Test]
        public void Test_Bank_TransferPayment_PartitionUnderMinimum()
        {
            decimal amount = 500.00m; 
            string result = bank.TransferPayment(receiver, amount);
            Assert.AreEqual("Cannot transfer less than 1000.00 euros!", result);
        }

        [Test]
        public void Test_Bank_TransferPayment_PartitionSuccessfulTransfer()
        {
            decimal amount = 2000.00m; 
            string result = bank.TransferPayment(receiver, amount);
            Assert.AreEqual("Transaction successful!", result);

            Assert.AreEqual(amount, receiver.Balance);
        }
    }
}
