using ATM_management_system.Models;
using ATM_management_system.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_management_system.Controllers
{

    public class MiniStatementController : Controller
    {
        ATMDbContext db = new ATMDbContext();
        // GET: MiniStatement
        public ActionResult MiniStatement(MinistatementViewModel ministatement)
        {
            var transactions = db.Transactions.Where(t => t.AccountNumber == ministatement.AccountNumber).ToList();

            if (transactions != null && transactions.Count > 0)
            {
                ViewBag.Transactions = transactions;
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "No transactions found";
                return View();
            }
        }
    }
}