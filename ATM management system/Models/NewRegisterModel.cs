using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class NewRegisterModel
    {
        [Required]
        public string CustomerName { get; set; }
        [Key] 
        public int AccountNumber { get; set; }
        [Required]
        public int PinNumber { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int ConfirmPinNumber { get; set; }
        [Required]
        public string Education { get; set; }
    }
}