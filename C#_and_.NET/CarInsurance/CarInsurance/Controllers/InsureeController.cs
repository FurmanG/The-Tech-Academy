using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,carYear,carMake,carModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //
                // calculate a quote based on the information the user inputs
                CalculateAquote(insuree);

                db.Insurees.Add(insuree);
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,carYear,carMake,carModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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


        //
        //PART FOUR SUBMISSION ASSIGNMENT
        //Add code logic that will calculate a quote based on the information the user inputs into the form.
        //1. In the InsureeController, add logic to calculate a quote based on these guidelines: 
        public Insuree CalculateAquote (Insuree insuree)
        {
            // a. Start with a base of $50 / month
            int totalQuote = 50;

            // Calculating age
            var datenow = DateTime.Today;
            var age = datenow.Year - insuree.DateOfBirth.Year;

            // b. If the user is 18 or under, add $100 to the monthly total.
            if ( age <= 18 )
            {
                totalQuote += 100;
            }

            // c. If the user is from 19 to 25, add $50 to the monthly total.
            if ( age >= 19 && age <= 25 )
            {
                totalQuote += 50;
            }

            // d. If the user is 26 or older, add $25 to the monthly total.
            if ( age >= 26 )
            {
                totalQuote += 25;
            }

            // e. If the car's year is before 2000, add $25 to the monthly total.
            if ( insuree.carYear < 2000 )
            {
                totalQuote += 25;
            }

            // f. If the car's year is after 2015, add $25 to the monthly total.
            if ( insuree.carYear > 2015 )
            {
                totalQuote += 25;
            }

            // g. If the car's Make is a Porsche, add $25 to the price.
            if ( insuree.carMake == "Porsche")
            {
                totalQuote += 25;
            }

            // h. If the car's Make is a Porsche and its model is a 911 Carrera,
            // add an additional $25 to the price. 
            if (insuree.carMake == "Porsche" && insuree.carModel == "911 Carrera")
            {
                totalQuote += 25;
            }

            // i. Add $10 to the monthly total for every speeding ticket the user has.
            if (insuree.SpeedingTickets > 0)
            {
                totalQuote += (10 * insuree.SpeedingTickets);
            }
            
            // j. If the user has ever had a DUI, add 25% to the total.
            if (insuree.DUI)
            {
                totalQuote += (totalQuote/4);
                    
            }

            // k. If it's full coverage, add 50% to the total.

            if (insuree.CoverageType)
            {
                totalQuote += (totalQuote / 2);

            }
      
            insuree.Quote = totalQuote;
            return insuree;
        }
    }
}
