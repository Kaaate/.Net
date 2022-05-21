using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public decimal OrderCost { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
    }
}
