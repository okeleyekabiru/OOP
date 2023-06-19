namespace OOP.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int? SenderAccountId { get; set; } 
        public int? ReceiverAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }

}
