using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Product
    {
        public Product()
        {
            this.IngredientsProducts = new List<IngredientsProduct>();
            this.InvoicesProducts = new List<InvoicesProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public virtual ICollection<IngredientsProduct> IngredientsProducts { get; set; }
        public virtual ICollection<InvoicesProduct> InvoicesProducts { get; set; }
    }
}
