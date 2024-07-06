using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlinePCShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerPhoneNumber { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public string Status { get; set; } = "Pending"; // Pending, Processed, Shipped, etc.
    }

    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
