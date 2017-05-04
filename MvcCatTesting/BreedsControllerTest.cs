using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcCat.Models;
using MvcCat.Controllers;
using System.Web.Mvc;

namespace MvcCatTesting
{
    [TestClass]
    public class BreedsControllerTest
    {        

        IModelBreed iModelBreed;
        BreedsController contBreed = new BreedsController();
        public IModelBreed IModelBreed { get => iModelBreed; set => iModelBreed = value; }

        [TestMethod]
        public void BreedIndex()
        {
            var view = contBreed.Index();
            Assert.AreNotEqual(null, view);
        }
        [TestMethod]
        public void BreedDetails()
        {
            ActionResult breed = contBreed.Details(1);
            Assert.AreNotEqual(null, breed);
        }

        [TestMethod]
        public void BreedCreate()
        {
            Breed breed = new Breed
            {                
                Name = "Test"
            };

            ActionResult aResult = contBreed.Create(breed);           
            Assert.IsInstanceOfType(aResult, typeof(ActionResult));            
            BreedDel(breed.Id);           
            
        }
        
        public void BreedDel(int id)
        {
            contBreed.Delete(id);
            contBreed.DeleteConfirmed(id);
        }
    }
}
