using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATM_management_system.ViewModel
{
    public class PinChangeViewModel
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string PIN { get; set; }
    }
}