using ATM_management_system.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//namespace ATM_management_system.Controllers
//{
//    public class UpdateContactDetails
//    {
//        ATMDbContext db = new ATMDbContext();
//        // GET: Contact/Update
//        [HttpGet]
//        public ActionResult Update()
//        {
//            // Retrieve the user's contact details from the database
//            var userId = (int)Session["UserId"];
//            var contact = db.ContactNumber.FirstOrDefault(c => c.UserId == userId);

//            if (contact == null)
//            {
//                // Contact details not found, create a new instance
//                contact = new Contact { UserId = userId };
//                db.Contacts.Add(contact);
//                _db.SaveChanges();
//            }

//            return View(contact);
//        }

//        // POST: Contact/Update
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Update(Contact contact)
//        {
//            if (ModelState.IsValid)
//            {
//                // Update the contact details
//                _dbContext.Entry(contact).State = EntityState.Modified;
//                _dbContext.SaveChanges();

//                ViewBag.Message = "Contact details updated successfully.";
//                return View(contact);
//            }

//            // Invalid contact details, display the form again with validation errors
//            return View(contact);
//        }
//    }
//}
//    }
//}