namespace CustomerBank
{
    public class BankCustomer
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public decimal Balance { get; set; }

        public int LoyaltyLevel { get; set; }
    }
}   
