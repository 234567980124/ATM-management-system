using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class LoginModel
    {
        public long AccountNumber { get; set; }
        public int PinNumber { get; set; }
        public int UserId { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}