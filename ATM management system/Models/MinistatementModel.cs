using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class MinistatementModel
    {
        [Key]
        public long AccountNumber { get; set; }
        public List<Transaction> Transactions { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TransactionDate { get; set; }
        public int CustomerId { get; set; }
    }
}