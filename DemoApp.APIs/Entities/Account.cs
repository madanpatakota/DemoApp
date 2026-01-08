namespace DemoApp.APIs.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string BankAccountNumber { get; set; }
        public decimal Balance { get; set; }

        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
    }
}
