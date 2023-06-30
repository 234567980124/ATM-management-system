using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.ViewModel
{
    public class DepositViewModel
    {
        public int Amount { get; set; }
        [Key]
        public int AccountId { get; set; }
        public int Deposit { get; set; }
        public long AccountNumber { get; set; }
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public decimal Balance { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Timestamp { get; set; }
    }
}