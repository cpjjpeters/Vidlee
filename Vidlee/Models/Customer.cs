using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidlee.Models
{
    public class Customer
    {
        public int Id { get; set; }
       // [Required]
       // [StringLength(125)]
        public string Name { get; set; }
        //public List<Customer> Customers { get; set; }
       // public bool IsSubscribedToNewsletter { get; set; }
       // public MembershipType MemberschipType { get; set; }
       // public byte MembershipTypeId { get; set; }
    }
}