using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            this.IngredientsProducts = new List<IngredientsProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<IngredientsProduct> IngredientsProducts { get; set; }
    }
}
