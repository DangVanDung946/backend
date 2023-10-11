using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }

        public DbSet<Product> MoviesList { get; set; } = null!;
    }
}


