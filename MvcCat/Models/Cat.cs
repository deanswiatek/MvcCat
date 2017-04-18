using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
}