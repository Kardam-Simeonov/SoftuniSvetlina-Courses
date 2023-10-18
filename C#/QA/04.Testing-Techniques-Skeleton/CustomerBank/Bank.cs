namespace CustomerBank
{
    public class Bank
    {
        private const decimal MinimumTransferAllowed = 1000.00m;
        private const decimal MaximumTransferAllowed = 4500.00m;
        private const decimal MinimumLoan = 1m;
        private const decimal MaximumLoan = 100000m;
        private const int MinimumLoyaltyNeeded = 100;

        public string TransferPayment(BankCustomer receiver, decimal amount)
        {
            // Check if the needed amount is over the accepted maximum
            if (this.IsOverMaximum(amount))
            {
                return $"Cannot transfer more than {MaximumTransferAllowed} euros!";
            }

            // Check if the needed amount is under the accepted minimum
            if (this.IsUnderMinimum(amount))
            {
                return $"Cannot transfer less than {MinimumTransferAllowed} euros!";
            }

            // Transfer the balance to the receivers' account
            receiver.Balance += amount;
            return "Transaction successful!";
        }

        public string RequestLoan(BankCustomer customer, decimal loan)
        {
            // Check the loan amount, it must be between 1 and 100000
            if (this.IsLoanOutsideRange(loan))
            {
                return
                    $"{customer.FullName}'s loan must be between {MinimumLoan} and {MaximumLoan}!";
            }

            // Check the loyalty level of the customer
            // Below 100 the customer cannot get a loan
            if (this.IsUnderLoyalty(customer.LoyaltyLevel))
            {
                return
                    $"{customer.FullName} does not have enough enough loyalty to request a loan!";
            }

            // Otherwise he gets the wanted loan
            return $"{customer.FullName} receives a loan of {loan}";
        }

        private bool IsLoanOutsideRange(decimal loan)
            => loan < MinimumLoan || loan > MaximumLoan;

        private bool IsUnderLoyalty(int loyalty)
            => loyalty < MinimumLoyaltyNeeded;

        private bool IsUnderMinimum(decimal amount)
            => amount < MinimumTransferAllowed;

        private bool IsOverMaximum(decimal amount)
            => amount > MaximumTransferAllowed;
    }
}
