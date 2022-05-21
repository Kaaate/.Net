using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    public class IngredientDish
    {
        [ForeignKey(nameof(Entities.Ingredient))]
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        [ForeignKey(nameof(Entities.Dish))]
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
