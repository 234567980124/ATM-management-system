using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class TransactionType
    {
        [Key]
        public int TransactionTypeId { get; set; }

        
        public string Type { get; set; }
        public decimal Balance { get; set; }

        public List<Transaction> Transactions { get; set; }


    }
}