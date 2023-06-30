using ATM_management_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.ViewModel
{
    public class AccountViewModel
    {
        [Key]
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int Deposit { get; set; }
        public int Withdrawal { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}