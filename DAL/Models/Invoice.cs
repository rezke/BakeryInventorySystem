using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            this.InvoicesProducts = new List<InvoicesProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoicesProduct> InvoicesProducts { get; set; }
    }
}
