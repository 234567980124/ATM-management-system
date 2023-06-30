using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class PinChangeModel
    {
        public int AccountId { get; set; }
        public int AccountNumber { get; set; }
        public string Username { get; set; }
        public string PIN { get; set; }
    }
}
