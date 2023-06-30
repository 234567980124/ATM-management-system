using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class CustomerInfo
    {
        [Key]
    
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string FatherName { get; set;  } 

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public string Education { get; set; }
        public int ConfirmPinNumber { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }

        
    }
}