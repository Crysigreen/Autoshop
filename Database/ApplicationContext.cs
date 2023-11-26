using Autoshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoshop.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Brand> brands { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Offer> offers { get; set; }
        public DbSet<User> users { get; set; }



        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
    }


}
