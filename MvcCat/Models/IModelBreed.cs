using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcCat.Models
{
    public interface IModelBreed
    {
        List<Breed> Index();
        Breed Details(int? id);        
        void Create(Breed breed);
        Breed SelectForDelete(int? i);
        void ConfirmDelete(int i);
        Breed SelectForEdit(int? i);
    }
}
