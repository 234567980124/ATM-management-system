using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM_management_system.ViewModel
{
    public class NewRegisterViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public int PinNumber { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int ConfirmPinNumber { get; set; }
        [Required]
        public string Education { get; set; }
    }
}