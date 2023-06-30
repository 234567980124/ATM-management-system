using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class Account
    {
            [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long AccountNumber { get; set; }

            [ForeignKey("User")]
            public int UserId { get; set; }
            public string PIN { get; set; }
            public decimal Balance { get; set; }
            public virtual User User { get; set; }

            public List<Transaction> Transactions { get; set; }

    }
}