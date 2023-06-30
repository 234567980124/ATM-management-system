using ATM_management_system.Models;
using ATM_management_system.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;

namespace ATM_management_system.Controllers
{
    public class ATMController : Controller
    {
        ATMDbContext db = new ATMDbContext();

        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "ATM");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Withdrawal()
        {
            long AccNo = 0;
            if (Session["AccNo"] != null)
            {
                AccNo = (long)Session["AccNo"];
            }
            ViewBag.Balance = db.Accounts.Find(AccNo).Balance;
            WithdrawalModel model = new WithdrawalModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Withdrawal(WithdrawalModel withdraw)
        {

            

            //if (ModelState.IsValid)
            //{
                // Retrieve the user's account from the list
                Account account = db.Accounts.FirstOrDefault(a => a.AccountNumber == withdraw.AccountNumber);
            
            
            if (account != null)
            {
                
                    // Check if the withdrawal amount is valid
                    if (account.Balance>withdraw.Amount)
                    

                {
                    Transaction transaction = new Transaction();
                    transaction.Account = account;
                    transaction.Withdrawal = 1;
                    transaction.Amount = withdraw.Amount;
                    transaction.Deposit = 0;
                    db.Transactions.Add(transaction);
                    // Perform the withdrawal
                    account.Balance -= withdraw.Amount;
                        
                        db.SaveChanges();
                    }
                    return RedirectToAction("WithdrawSuccess");
                    }
                        else
                    {
                        ModelState.AddModelError("Amount", "Invalid withdrawal amount.");
                    }
        
                return View();
            }

            public ActionResult WithdrawalSuccess()
            {
                // Display a success message or render a success view
                return View();
            }
        }
    }



