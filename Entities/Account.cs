namespace OOP.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public AccountType? Type { get; set; }
        public decimal? Balance { get; set; }
        public int UserId { get; set; }
    }
}