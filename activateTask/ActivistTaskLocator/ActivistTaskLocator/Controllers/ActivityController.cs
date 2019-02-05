using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivistTaskLocator.Models;

namespace ActivistTaskLocator.Controllers
{
    public class ActivityController : Controller
    {
        private ActivityDBContext db = new ActivityDBContext();

        //
        // GET: /Activity/

        public ActionResult Index()
        {
            return View(db.ActivityList.ToList());
        }

        //
        // GET: /Activity/Details/5

        public ActionResult Details(int id = 0)
        {
            Activities activities = db.ActivityList.Find(id);
            if (activities == null)
            {
                return HttpNotFound();
            }
            return View(activities);
        }

        //
        // GET: /Activity/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Activity/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Activities activities)
        {
            if (ModelState.IsValid)
            {
                db.ActivityList.Add(activities);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activities);
        }

        //
        // GET: /Activity/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Activities activities = db.ActivityList.Find(id);
            if (activities == null)
            {
                return HttpNotFound();
            }
            return View(activities);
        }

        //
        // POST: /Activity/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Activities activities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activities).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activities);
        }

        //
        // GET: /Activity/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Activities activities = db.ActivityList.Find(id);
            if (activities == null)
            {
                return HttpNotFound();
            }
            return View(activities);
        }

        //
        // POST: /Activity/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Activities activities = db.ActivityList.Find(id);
            db.ActivityList.Remove(activities);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult SearchIndex(string searchString)
        {
            var activity = from m in db.ActivityList
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                activity = activity.Where(s => s.Address.Contains(searchString));
            }

            return View(activity);
        }

    }
}