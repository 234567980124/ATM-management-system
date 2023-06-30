using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class AccountModel
    {
        
        
        public decimal Balance { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AccountNumber { get; set; }
        public int Deposit { get; set; }
        public int Withdrawal { get; set; }

    }
}