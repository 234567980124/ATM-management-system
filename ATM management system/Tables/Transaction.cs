using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("Account")]
        public long AccountNumber { get; set; }
        public virtual Account Account { get; set; }

        //[ForeignKey("TransactionType")]
        //public int TransactionTypeId { get; set; }
        public int AtmId  { get; set; }
        public int Deposit { get; set; }
        public int Withdrawal { get; set; }
        //public virtual Atm Atm { get; set; }
        public int Amount { get; set; }
        //public virtual TransactionType TransactionType { get; set; }
        public string TransactionType { get; set; }
        public decimal Balance { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TransactionDate { get; set; }


    }
}