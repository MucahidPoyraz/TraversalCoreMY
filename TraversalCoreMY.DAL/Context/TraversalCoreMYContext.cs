using Microsoft.EntityFrameworkCore;
using TraversalCoreMY.Entity.Concrete.About;
using TraversalCoreMY.Entity.Concrete.Concact;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.DAL.Context
{
    public class TraversalCoreMYContext : DbContext
    {
        public TraversalCoreMYContext(DbContextOptions<TraversalCoreMYContext> options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Featured> Featureds { get; set; }
        public DbSet<HomeAbout> HomeAbouts { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
