using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    public class DishModel
    { 
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Recipe { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
