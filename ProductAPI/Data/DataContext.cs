using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DbContext> options) : base(options) {
        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }


    }
}
