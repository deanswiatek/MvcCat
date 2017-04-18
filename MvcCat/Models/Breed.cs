using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
}