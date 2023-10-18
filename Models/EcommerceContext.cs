using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }

        public DbSet<Product> ProductsList { get; set; } = null!;

        public DbSet<Slide> SlidesList { get; set; } = null!;

        public DbSet<Category> CategoriesList { get; set; } = null!;

        public DbSet<ImageIcon> ImageIconsList { get; set; } = null!;

        public DbSet<User> UsersList { get; set; } = null!;
    }
}


