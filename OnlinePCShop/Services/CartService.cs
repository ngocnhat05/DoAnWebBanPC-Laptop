using OnlinePCShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlinePCShop.Services
{
    public class CartService
    {
        private List<Product> cartItems = new List<Product>();
        public CustomerInfo Customer { get; private set; } = new CustomerInfo();
        public List<Product> PurchasedItems { get; private set; } = new List<Product>();
        public string NotificationMessage { get; private set; } = string.Empty;

        public List<Product> GetCartItems()
        {
            return cartItems;
        }

        public void AddToCart(Product product)
        {
            var existingItem = cartItems.FirstOrDefault(p => p.Id == product.Id);
            if (existingItem == null)
            {
                product.Quantity = 1;
                cartItems.Add(product);
            }
            else
            {
                existingItem.Quantity += 1;
            }
            NotificationMessage = "Sản phẩm đã được thêm vào giỏ hàng.";
        }

        public void RemoveFromCart(Product product)
        {
            cartItems.Remove(product);
        }

        public decimal GetTotalPrice()
        {
            return cartItems.Where(item => item.IsSelected).Sum(item => item.Price * item.Quantity);
        }

        public bool HasSelectedItems()
        {
            return cartItems.Any(item => item.IsSelected);
        }

        public void SetCustomerInfo(CustomerInfo customer)
        {
            Customer = customer;
        }

        public void AddPurchasedItems(List<Product> purchasedItems)
        {
            PurchasedItems.AddRange(purchasedItems);
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }
    }
}
