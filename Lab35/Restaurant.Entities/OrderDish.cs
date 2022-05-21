using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    public class OrderDish
    {
        [ForeignKey(nameof(Entities.Order))]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey(nameof(Entities.Dish))]
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
