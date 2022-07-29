using System;
using System.Collections.Generic;

#nullable disable

namespace HotelManagement.Models
{
    public partial class Room
    {
        public Room()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int IdType { get; set; }

        public virtual RoomType IdTypeNavigation { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
