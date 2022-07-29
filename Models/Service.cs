using System;
using System.Collections.Generic;

#nullable disable

namespace HotelManagement.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public string NameService { get; set; }
        public int Price { get; set; }
    }
}
