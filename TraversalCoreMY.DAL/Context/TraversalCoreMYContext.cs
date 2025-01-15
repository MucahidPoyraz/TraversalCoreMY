using Microsoft.EntityFrameworkCore;
using TraversalCoreMY.Entity.Concrete.About;
using TraversalCoreMY.Entity.Concrete.Blog;
using TraversalCoreMY.Entity.Concrete.Concact;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.DAL.Context
{
    public class TraversalCoreMYContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MUCAHID\MSSQLSERVER01;Database=TraversalCoreMYContextDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Featured> Featureds { get; set; }
        public DbSet<HomeAbout> HomeAbouts { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
