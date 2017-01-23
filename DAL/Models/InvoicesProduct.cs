using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class InvoicesProduct
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
