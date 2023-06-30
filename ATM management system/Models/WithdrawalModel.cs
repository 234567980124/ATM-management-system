using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class WithdrawalModel
    {
        
        //10,000
        public int Amount { get; set; }

        [Key]
        public int AccountId { get; set; }
        //10,000
        //public int Withdraw { get; set; }
        
        public long AccountNumber { get; set; }
    }
}