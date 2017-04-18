namespace MvcCat.Migrations
{
    using MvcCat.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcCat.Models.CatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CatContext context)
        {
            var breeds = new List<Breed>
            {
                new Breed { Name = "Black" },
                new Breed { Name = "Tabby" },
                new Breed { Name = "Calico" },
                new Breed { Name = "Serval" },
                new Breed { Name = "Tiger" },
                new Breed { Name = "Persian" },
                new Breed { Name = "Jaguar" },
                new Breed { Name = "Mountain Lion" }
            };

            context.Breeds.AddRange(breeds);
            context.SaveChanges();
        }
    }
}
