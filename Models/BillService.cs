using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace HotelManagement.Models
{
    public partial class BillService
    {
        public int? BillId { get; set; }
        public int? ServiceId { get; set; }
        public int Count { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Service Service { get; set; }
    }
}
