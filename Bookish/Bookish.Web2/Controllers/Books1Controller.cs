using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bookish.Web2;

namespace Bookish.Web2.Controllers
{
    public class Books1Controller : Controller
    {
        private BookishEntities db = new BookishEntities();

        // GET: Books1
        public ActionResult Index()
        {
            return View(db.Books1.ToList());
        }

        // GET: Books1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Books1 books1 = db.Books1.Find(id);
            if (books1 == null)
            {
                return HttpNotFound();
            }
            return View(books1);
        }

        // GET: Books1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookID,ISBN,Title,Author,Barcode")] Books1 books1)
        {
            if (ModelState.IsValid)
            {
                db.Books1.Add(books1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(books1);
        }

        // GET: Books1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Books1 books1 = db.Books1.Find(id);
            if (books1 == null)
            {
                return HttpNotFound();
            }
            return View(books1);
        }

        // POST: Books1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookID,ISBN,Title,Author,Barcode")] Books1 books1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(books1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(books1);
        }

        // GET: Books1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Books1 books1 = db.Books1.Find(id);
            if (books1 == null)
            {
                return HttpNotFound();
            }
            return View(books1);
        }

        // POST: Books1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Books1 books1 = db.Books1.Find(id);
            db.Books1.Remove(books1);
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
