using Microsoft.EntityFrameworkCore;
using reposatywithuow.Entities.Models;

namespace reposatywithuow.Entities.Context
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) { }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<order> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Eshop2;Integrated Security=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
