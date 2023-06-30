using ATM_management_system.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_management_system.Controllers
{
    public class PinChangeController : Controller
    {
        ATMDbContext db = new ATMDbContext();
        // GET: PinChange
        [HttpGet]
        public ActionResult PinChange()
        {
            // Display the pin change form
            return View();
        }

        [HttpPost]
        public ActionResult PinChange(PinChangeModel pinchange, string newpin)
        {
            Account account = db.Accounts.FirstOrDefault(a => a.AccountNumber == pinchange.AccountNumber);
            // Perform the pin change operation
            var Account = db.Accounts.FirstOrDefault(a => a.AccountNumber == pinchange.AccountNumber);

            if (account != null)
            {
                // Update the account's pin
                account.PIN = newpin;


                // Save changes to the database
                db.SaveChanges();

                ViewBag.Message = "Pin change successfull";
            }

            return View(); // Pin change failed
        }
    }

}
