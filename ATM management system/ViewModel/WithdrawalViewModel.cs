using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.ViewModel
{
    public class WithdrawalViewModel
    {
        public int Amount { get; set; }
        [Key]
        public int AccountId { get; set; }

        public int Withdraw { get; set; }
        
        public long AccountNumber { get; set; }
    }
}