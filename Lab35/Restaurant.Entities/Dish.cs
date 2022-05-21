using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    public class Dish 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        public RestaurantEntity Restaurant { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Recipe { get; set; }
        public List<IngredientDish> IngredientDishes { get; set; }
        public List<OrderDish> OrderDishes { get; set; }
    }
}
