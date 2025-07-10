﻿namespace ESHOPONLINE.Models
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public int OrderId { get; set; }
        public String UserId { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public ApplicationUser User{ get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } 
    }
}
