namespace SearchAccountEx.Models
{
    public class Invoice
    {
        // This class will include properties like
        // AccountName, InvoiceNumber, AmountDue, etc.

        public int InvoiceId { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? AccountName { get; set; }
        public decimal AmountDue { get; set; }
        public DateTime DueDate { get; set; }
        // Other relevant properties...

        // Navigation property to PaymentTransaction (if needed)
        public ICollection<PaymentTransaction>? PaymentTransactions { get; set; }
    }
}
