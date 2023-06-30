using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public long AccountNumber { get; set; }
        //public string UserRole { get; set; }
        [Range(1000, 9999, ErrorMessage = "Pin code must be Four Digit.")]
        public int PinNumber { get; set; }

        public List<Card> Cards { get; set; }

        public List<Account> Accounts { get; set; }
        [Required]
        public CustomerInfo CustomerInfo { get; set; }

        public bool IsAdmin { get; set; }
    }
}