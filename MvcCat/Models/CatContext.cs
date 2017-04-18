using System.Data.Entity;

namespace MvcCat.Models
{
    public class CatContext : DbContext
    {
        public CatContext() : base("CatContext")
        {
        }

        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Cat> Cats{ get; set; }
    }
}
