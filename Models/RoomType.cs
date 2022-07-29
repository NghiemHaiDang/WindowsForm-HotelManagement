using System;
using System.Collections.Generic;

#nullable disable

namespace HotelManagement.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string NameType { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
