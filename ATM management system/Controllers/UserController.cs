using ATM_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ATM_management_system.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        ATMDbContext db = new ATMDbContext();
        public ActionResult Login()

        {
            //Account login = new Account();
            return View();
    }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var Users = db.Users.Where(i => i.AccountNumber == model.AccountNumber && i.PinNumber == model.PinNumber).FirstOrDefault();

            if (Users != null)
            {
                Session.Add("AccNo", Users.AccountNumber);
                Session["UserId"] = Users.UserId;
                Session["IsAdmin"]= Users.IsAdmin;
                Session.Add("SignInTime", DateTime.Now);
                return RedirectToAction("Index", "ATM");
            }
            else

                //return RedirectToAction("ATM");
                ViewBag.Message = "Error occurred - Login Credential Invalid !!";
            return View("Error");

            //return RedirectToAction("");
            //return View();
        }
            public ActionResult Logout()
    {
        Session.Remove("LoggedInUser");

        return RedirectToAction("Login");
    }
        public ActionResult NewRegister()

        {
            NewRegisterModel model = new NewRegisterModel();
            return View(model);
        }


   [HttpPost]
    public ActionResult NewRegister(NewRegisterModel registerModel)
    {
            string data = string.Empty;
        //if (ModelState.IsValid)
        //{
                data += "1 ";
            User newUser = new User
            {
                AccountNumber = registerModel.AccountNumber,
                PinNumber = registerModel.PinNumber,
                CustomerInfo = new CustomerInfo
                {
                    CustomerName = registerModel.CustomerName,
                    FatherName = registerModel.FatherName,
                    Address = registerModel.Address,
                    DOB = registerModel.DateOfBirth,
                    PhoneNumber = registerModel.ContactNo,
                    Education = registerModel.Education,
                    ConfirmPinNumber = registerModel.ConfirmPinNumber

                }

            };
                data += "2 ";
                db.Users.Add(newUser);
            db.SaveChanges();
            Account userAccount = new Account();
            userAccount.UserId = newUser.UserId;
            userAccount.AccountNumber = newUser.AccountNumber;
            userAccount.Balance = 50000;
            userAccount.PIN = newUser.PinNumber.ToString();
            db.Accounts.Add(userAccount);
            db.SaveChanges();
            return RedirectToAction("Login","User");
        //}
            return Content(data);
        return View(registerModel);
    }
}
}