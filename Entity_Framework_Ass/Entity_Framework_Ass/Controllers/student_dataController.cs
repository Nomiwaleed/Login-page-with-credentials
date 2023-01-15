using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entity_Framework_Ass.Models;

namespace Entity_Framework_Ass.Controllers
{
    public class student_dataController : Controller
    {
        private StudentEntities2 db = new StudentEntities2();

        // GET: student_data
        public ActionResult Index()
        {
            return View(db.student_data.ToList());
        }

        // GET: student_data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_data student_data = db.student_data.Find(id);
            if (student_data == null)
            {
                return HttpNotFound();
            }
            return View(student_data);
        }

        // GET: student_data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: student_data/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "student_id,student_Name,student_FatherName,student_age,Email")] student_data student_data)
        {
            if (ModelState.IsValid)
            {
                db.student_data.Add(student_data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_data);
        }

        // GET: student_data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_data student_data = db.student_data.Find(id);
            if (student_data == null)
            {
                return HttpNotFound();
            }
            return View(student_data);
        }

        // POST: student_data/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "student_id,student_Name,student_FatherName,student_age,Email")] student_data student_data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_data);
        }

        // GET: student_data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_data student_data = db.student_data.Find(id);
            if (student_data == null)
            {
                return HttpNotFound();
            }
            return View(student_data);
        }

        // POST: student_data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            student_data student_data = db.student_data.Find(id);
            db.student_data.Remove(student_data);
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
