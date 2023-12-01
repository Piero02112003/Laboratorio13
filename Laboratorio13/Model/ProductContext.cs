using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Model
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
