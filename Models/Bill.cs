using System;
using System.Collections.Generic;

#nullable disable

namespace HotelManagement.Models
{
    public partial class Bill
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? RoomId { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int ExtraCharge { get; set; }
        public bool Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
