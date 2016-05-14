using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventMVC.Models;
using System.Web.Security;

namespace EventMVC.Controllers
{
    public class EventController : Controller
    {
        private EventDBContext db = new EventDBContext();

        //
        // GET: /Event/
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        //
        // GET: /Event/Details/5

        public ActionResult Details(int id = 0)
        {
            Event _event = db.Events.Find(id);
            if (_event == null)
            {
                return HttpNotFound();
            }
            return View(_event);
        }

        //
        // GET: /Event/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Event/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Event _event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(_event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(_event);
        }

        //
        // GET: /Event/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Event _event = db.Events.Find(id);
            if (_event == null)
            {
                return HttpNotFound();
            }
            return View(_event);
        }

        //
        // POST: /Event/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Event _event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(_event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(_event);
        }

        //
        // GET: /Event/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Event _event = db.Events.Find(id);
            if (_event == null)
            {
                return HttpNotFound();
            }
            return View(_event);
        }

        //
        // POST: /_event/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event _event = db.Events.Find(id);
            db.Events.Remove(_event);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}