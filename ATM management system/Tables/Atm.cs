using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class Atm
    {
        [Key]
        public int ATMId { get; set; }

        public string ATMName { get; set; }

        public string Location { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}