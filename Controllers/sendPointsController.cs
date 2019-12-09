using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200Team8v2.DAL;
using MIS4200Team8v2.Models;
using System.Net.Mail;

namespace MIS4200Team8v2.Controllers
{
    public class sendPointsController : Controller
    {
        private MIS4200Team8Context db = new MIS4200Team8Context();

        // GET: sendPoints
        public ActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                return View(db.sendPointss.ToList());
            }
            else
            {
                return View("NotAuthenticated");
            }
            var sendPointss = db.sendPointss.Include(s => s.CoreValues).Include(s => s.UserDetail);
            return View(sendPointss.ToList());


        }

        // GET: sendPoints/Details/5
        public ActionResult Details(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(db.userDetails.ToList());
            }
            else
            {
                return View("NotAuthenticated");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sendPoints sendPoints = db.sendPointss.Find(id);
            if (sendPoints == null)
            {
                return HttpNotFound();
            }
            return View(sendPoints);
        }

        // GET: sendPoints/Create
        public ActionResult Create()
        {


            
            
            ViewBag.valueID = new SelectList(db.coreValuess, "valueID", "valueName");

            ViewBag.userID = new SelectList(db.userDetails, "userID", "firstName");
            return View();
        }

        // POST: sendPoints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pointsID,userID,valueID,PointValue,recognitionTime,description")] sendPoints sendPoints)
        {
            if (ModelState.IsValid)
            {
                db.sendPointss.Add(sendPoints);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.valueID = new SelectList(db.coreValuess, "valueID", "valueName", sendPoints.valueID);
            ViewBag.userID = new SelectList(db.userDetails, "userID", "firstName", sendPoints.userID);
            return View(sendPoints);

        }

        // GET: sendPoints/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sendPoints sendPoints = db.sendPointss.Find(id);
            if (sendPoints == null)
            {
                return HttpNotFound();
            }
            ViewBag.valueID = new SelectList(db.coreValuess, "valueID", "valueName", sendPoints.valueID);
            ViewBag.userID = new SelectList(db.userDetails, "userID", "firstName", sendPoints.userID);
            return View(sendPoints);
        }

        // POST: sendPoints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pointsID,userID,valueID,PointValue,recognitionTime,description")] sendPoints sendPoints)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sendPoints).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.valueID = new SelectList(db.coreValuess, "valueID", "valueName", sendPoints.valueID);
            ViewBag.userID = new SelectList(db.userDetails, "userID", "firstName", sendPoints.userID);
            return View(sendPoints);
        }

        // GET: sendPoints/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sendPoints sendPoints = db.sendPointss.Find(id);
            if (sendPoints == null)
            {
                return HttpNotFound();
            }
            return View(sendPoints);
        }

        // POST: sendPoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sendPoints sendPoints = db.sendPointss.Find(id);
            db.sendPointss.Remove(sendPoints);
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
