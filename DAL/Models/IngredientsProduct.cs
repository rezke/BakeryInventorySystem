using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class IngredientsProduct
    {
        public int IngredientId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual Product Product { get; set; }
    }
}
