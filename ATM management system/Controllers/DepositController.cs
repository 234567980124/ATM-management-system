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
    public class DepositController : Controller
    {
        ATMDbContext db = new ATMDbContext();


        //GET: ATM/Withdraw
       

        [HttpGet]
        public ActionResult Deposit()
        {
            DepositModel deposit = new DepositModel();
            deposit.Timestamp = DateTime.Now;

            deposit.TransactionType = "Deposit";
            long AccNo = 0;
            if (Session["AccNo"] != null)
            {
                AccNo = (long)Session["AccNo"];
                deposit.Balance = db.Accounts.Find(AccNo).Balance;
                deposit.AccountNumber = AccNo;
            }
             else
            {
                return RedirectToAction("Login", "User");
            }   
            return View(deposit);
        }

        [HttpPost]
        public ActionResult Deposit(DepositModel deposit)
        {
            // Perform the deposit operation
            var account = db.Accounts.FirstOrDefault(a => a.AccountNumber == deposit.AccountNumber);

            if (account != null)
            {
                // Update the account balance
                account.Balance += deposit.Amount;

                // Save changes to the database
                db.SaveChanges();
                Transaction t = new Transaction();
                t.AccountNumber = deposit.AccountNumber;
                t.Amount = deposit.Amount;
                t.TransactionType = deposit.TransactionType;
                t.Withdrawal = 0;
                t.Deposit = deposit.Amount;
                t.Balance = t.Balance + t.Deposit;
                t.AtmId = (new Random()).Next(10000,99999);
                t.TransactionDate = deposit.Timestamp;
                db.Transactions.Add(t);
                db.SaveChanges();
                ViewBag.Message = "Deposit Successful";
                return View("Success");
            }
            else
            {

                ViewBag.Message = "Account Details Invalid";
                return View("Error");
            }
            
        }
    }
}

