using System;
using System.Collections.Generic;

#nullable disable

namespace HotelManagement.Models
{
    public partial class Account
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
    }
}
