using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcCat.Models;
using MvcCat.Controllers;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Web.Mvc;


namespace MvcCatTesting
{
    [TestClass]
    public class CatsControllerTest
    {
        IModelCat iModelCat;       
        CatsController contCat = new CatsController();

        public IModelCat IModelCat1 { get => iModelCat; set => iModelCat = value; }

        [TestMethod]
        public void CatIndex()
        {
            //Test that returns an index view, makes sure view is not null                      
            var view = contCat.Index();
            Assert.AreNotEqual(null, view);
        }

        [TestMethod]
        public void CatDetails()
        {
            ActionResult cat = contCat.Details(1);
            Assert.AreNotEqual(null, cat);
        }
        [TestMethod]
        public void CreateCat()
        {
            ActionResult r = contCat.Create();
            Assert.AreNotEqual(null, r);
        }
        //Todo: Test methods for each Query to continue.
        
    }
}
