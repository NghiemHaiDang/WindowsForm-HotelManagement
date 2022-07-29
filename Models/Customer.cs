using System;
using System.Collections.Generic;

#nullable disable

namespace HotelManagement.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string IdCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string UniqueName
        {
            get
            {
                return $"{Id}.{Name} ({AddDate})";
            }
        }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
