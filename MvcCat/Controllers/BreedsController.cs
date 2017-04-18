using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MvcCat.Models;

namespace MvcCat.Controllers
{
    public class BreedsController : Controller
    {
        private CatContext db = new CatContext();

        // GET: Breeds
        public ActionResult Index()
        {
            return View(db.Breeds.OrderBy(b => b.Name).ToList());
        }

        // GET: Breeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return HttpNotFound();
            }
            return View(breed);
        }

        // GET: Breeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Breeds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Breed breed)
        {
            if (ModelState.IsValid)
            {
                db.Breeds.Add(breed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(breed);
        }

        // GET: Breeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return HttpNotFound();
            }
            return View(breed);
        }

        // POST: Breeds/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Breed breed)
        {
            if (ModelState.IsValid)
            {
                db.Entry(breed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(breed);
        }

        // GET: Breeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return HttpNotFound();
            }
            return View(breed);
        }

        // POST: Breeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Breed breed = db.Breeds.Find(id);
            db.Breeds.Remove(breed);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
