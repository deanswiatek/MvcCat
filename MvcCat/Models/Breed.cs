using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace MvcCat.Models
{
    public class Breed
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Breed Name")]
        public string Name { get; set; }

        public virtual ICollection<Cat> Cats { get; set; }
    }
    public class BreedData : IModelBreed
    {
        private CatContext db = new CatContext();

        public List<Breed> Index()
        {
            List<Breed> breeds = db.Breeds.OrderBy(b => b.Name).ToList();
            return breeds;
        }

        public Breed Details(int? id)
        {            
            Breed breed = db.Breeds.Find(id);
            return breed;
        }

        public void Create(Breed breed)
        {
            db.Breeds.Add(breed);
            db.SaveChanges();
        }
        public Breed SelectForDelete(int? id)
        {
            Breed breed = db.Breeds.Find(id);
            return breed;
        }
        public void ConfirmDelete(int id)
        {
            Breed breed = db.Breeds.Find(id);
            db.Breeds.Remove(breed);
            db.SaveChanges();
        }
        public Breed SelectForEdit(int? id)
        {
            Breed breed = db.Breeds.Find(id);
            return breed;
        }
    }
}