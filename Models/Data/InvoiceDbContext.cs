using Microsoft.EntityFrameworkCore;

namespace SearchAccountEx.Models.Data
{
    public class InvoiceDbContext :  DbContext
    {
        // DbSet properties
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }

        // Constructor with options to configure the context
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure primary key for Invoice
            modelBuilder.Entity<Invoice>().HasKey(i => i.InvoiceId);

            // Configure relationship between Invoice and PaymentTransaction
            modelBuilder.Entity<PaymentTransaction>()
                .HasOne(pt => pt.Invoice)
                .WithMany(i => i.PaymentTransactions)
                .HasForeignKey(pt => pt.InvoiceId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
