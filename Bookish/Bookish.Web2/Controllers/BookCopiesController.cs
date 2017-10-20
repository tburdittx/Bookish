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
    public class BookCopiesController : Controller
    {
        private BookishEntities db = new BookishEntities();

        // GET: BookCopies
        public ActionResult Index()
        {
            var bookCopies = db.BookCopies.Include(b => b.Customer).Include(b => b.Books1).Include(b => b.BookCopy1).Include(b => b.BookCopy2).Include(b => b.Books11);
            return View(bookCopies.ToList());
        }

        // GET: BookCopies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookCopy bookCopy = db.BookCopies.Find(id);
            if (bookCopy == null)
            {
                return HttpNotFound();
            }
            return View(bookCopy);
        }

        // GET: BookCopies/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CUSTOMERID", "FirstName");
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN");
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID");
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID");
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN");
            return View();
        }

        // POST: BookCopies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookCopyID,CustomerID,ReturnDate,BookID")] BookCopy bookCopy)
        {
            if (ModelState.IsValid)
            {
                db.BookCopies.Add(bookCopy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CUSTOMERID", "FirstName", bookCopy.CustomerID);
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN", bookCopy.BookID);
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID", bookCopy.BookCopyID);
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID", bookCopy.BookCopyID);
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN", bookCopy.BookID);
            return View(bookCopy);
        }

        // GET: BookCopies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookCopy bookCopy = db.BookCopies.Find(id);
            if (bookCopy == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CUSTOMERID", "FirstName", bookCopy.CustomerID);
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN", bookCopy.BookID);
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID", bookCopy.BookCopyID);
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID", bookCopy.BookCopyID);
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN", bookCopy.BookID);
            return View(bookCopy);
        }

        // POST: BookCopies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookCopyID,CustomerID,ReturnDate,BookID")] BookCopy bookCopy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookCopy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CUSTOMERID", "FirstName", bookCopy.CustomerID);
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN", bookCopy.BookID);
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID", bookCopy.BookCopyID);
            ViewBag.BookCopyID = new SelectList(db.BookCopies, "BookCopyID", "BookID", bookCopy.BookCopyID);
            ViewBag.BookID = new SelectList(db.Books1, "BookID", "ISBN", bookCopy.BookID);
            return View(bookCopy);
        }

        // GET: BookCopies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookCopy bookCopy = db.BookCopies.Find(id);
            if (bookCopy == null)
            {
                return HttpNotFound();
            }
            return View(bookCopy);
        }

        // POST: BookCopies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookCopy bookCopy = db.BookCopies.Find(id);
            db.BookCopies.Remove(bookCopy);
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
