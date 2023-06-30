using ATM_management_system.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ATM_management_system.Controllers
{
    public class BalanceController : Controller
    {
        ATMDbContext db = new ATMDbContext();


        [HttpGet]
        public ActionResult CheckBalance()
        {
            //Display the check balance form
            return View();
        }
        //Balance/CheckBalance
        [HttpPost]
        public ActionResult CheckBalance(AccountModel balance)
        {
            // Check if the account exists
            if (ModelState.IsValid)
            {
                var Account = db.Accounts.Any(a => a.AccountNumber == balance.AccountNumber);


                {
                    // Get the account balance
                    var account = db.Accounts.FirstOrDefault(a => a.Balance == balance.AccountNumber);

                    if (account != null)
                    {
                        return ViewBag.Balance = balance;
                    }

                    // Pass the balance to the view
                   
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Account not found";
                return View();
            }
        }
    }
}


