namespace DemoApp.APIs.Entities
{

    public enum TxType
    {
        Deposit = 1,
        Withdrawal = 2,
        Transfer = 3
    }


    public class BankTransaction
    {
        public int ID { get; set; }

        public int AccountID { get; set; }

        public int TxType { get; set; }

        public decimal Amount { get; set; }

        public DateTime PerformedAt { get; set; }
    }
}
