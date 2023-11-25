using Microsoft.EntityFrameworkCore;

namespace Autoshop.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Brand> brands { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }


}
