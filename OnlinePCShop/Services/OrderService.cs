using OnlinePCShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlinePCShop.Services
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        private List<Order> processedOrders = new List<Order>();
        private int nextOrderId = 1;

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public List<Order> GetProcessedOrders()
        {
            return processedOrders;
        }

        public Order GetOrderById(int orderId)
        {
            return orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void CreateOrder(Order order)
        {
            order.OrderId = nextOrderId++;
            order.OrderDate = DateTime.Now;
            orders.Add(order);
        }

        public void ProcessOrder(int orderId)
        {
            var order = GetOrderById(orderId);
            if (order != null)
            {
                order.Status = "Processed";
                orders.Remove(order);
                processedOrders.Add(order);
            }
        }
    }
}
