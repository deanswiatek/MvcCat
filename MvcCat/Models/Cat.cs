using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;

namespace MvcCat.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cat Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Breed")]
        public int BreedId { get; set; }

        [Display(Name = "Breed")]
        public virtual Breed Breed { get; set; }

        
        
    }

    public class CatData : IModelCat
    {
        private CatContext db = new CatContext();
        public List<Cat> Index()
        {
            var cats = db.Cats.Include(c => c.Breed).OrderBy(c => c.Name);
            return ConvertQueryToList(cats);
        }
        public List<T> ConvertQueryToList<T>(IQueryable<T> query)
        {
            return query.ToList();
        }
        public Cat Details(int? id)
        {
            Cat cat = db.Cats.Find(id);
            return cat;
        }
        public SelectList Create()
        {
            SelectList list = new SelectList(db.Breeds, "Id", "Name");
            return list;
        }
    }
}