using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcCat.Models
{
    public interface IModelCat
    {
        List<Cat> Index();
        Cat Details(int? id);
        SelectList Create();
        //etc...

        //Todo:        
        //Would continue to pull from the IModelCat for the rest of the Queries 
        //Also would create IModelBreed and a BreedData class which would exted the iModelBreed interface
        //to simply decouple the controller from the data.
        //Also Tests for each query would be created before the refactoring of each method.         

    }
}
