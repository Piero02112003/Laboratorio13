using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Model
{
    public class InvoiceContext: DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {

        }

        public DbSet<Invoice> Invoices { get; set; }
    }
}
