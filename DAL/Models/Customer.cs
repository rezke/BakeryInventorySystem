using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Invoices = new List<Invoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string JIB { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
