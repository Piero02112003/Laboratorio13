using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Model
{
    public class CustomerContext: DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
