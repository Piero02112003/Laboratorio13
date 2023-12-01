using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Model
{
    public class DetailContext: DbContext
    {
        public DetailContext(DbContextOptions<DetailContext> options) : base(options)
        {

        }

        public DbSet<Detail> Details { get; set; }
    }
}
