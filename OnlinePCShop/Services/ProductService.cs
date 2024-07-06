using OnlinePCShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlinePCShop.Services
{
    public class ProductService
    {
        private List<Product> products = new List<Product>
        {
            //Laptop
            new Product { Id = 1, Name = "ASUS TUF Gaming A15 2021", Description = "Màn hình: 15.6” 144/240Hz, CPU: Ryzen 5000 Series, RAM: 8GB DDR4-3200, SSD: 512GB 1TB, VGA: RTX 30 Series, Trọng lượng: 2.3 kg", Price = 449, ImageUrl = "https://i.imgur.com/ioyGBH2.jpeg" },
            new Product { Id = 2, Name = "ASUS TUF Gaming A15 2023", Description = "Màn hình: 15.6” 144Hz FHD Display, Intel Core i5-11400H Processor, GeForce RTX 2050, 8GB DDR4 RAM, 512GB PCIe SSD Gen 3, Wi-Fi 6, Windows 11, FX506HF-ES51,Graphite Black", Price = 534, ImageUrl = "https://i.imgur.com/1yYbQQc.jpeg" },
            new Product { Id = 3, Name = "ASUS TUF Gaming F15 2022", Description = "Màn hình: 15.6” FHD 144Hz Display, GeForce RTX 3050, Intel Core i5-12500H, 16GB DDR4, 512GB PCIe SSD, Wi-Fi 6, Windows 11, FX507ZC-ES53,Mecha Gray", Price = 672, ImageUrl = "https://i.imgur.com/fW4Xd64.jpeg" },
            new Product { Id = 4, Name = "Acer Nitro 5 Tiger", Description = "Màn hình 15.6” 144Hz độ phân giải Full HD, GeForce RTX 3050, Intel Core i5-12500H, 8GB DDR4, 512GB PCIe SSD, Windows 11, AN515 58 52SP, Black", Price = 669, ImageUrl = "https://i.imgur.com/ec2qEfZ.jpeg" },
            new Product { Id = 5, Name = "Acer Nitro 5", Description = "Màn hình 15.6” 144Hz độ phân giải Full HD, GeForce RTX 3050, Intel Core i5-11400H, 8GB DDR4, 512GB SSD, Windows 11, AN515-57-53F9, Black", Price = 677, ImageUrl = "https://i.imgur.com/P0AeUW1.jpeg" },
            new Product { Id = 6, Name = "Acer Nitro V", Description = "Màn hình 15.6” 144Hz FHD, GeForce RTX 3050, Intel Core i5-12500H, 8GB DDR4, 512GB SSD, Windows 11, AN515-58-57Y8, Black", Price = 1667, ImageUrl = "https://i.imgur.com/42sd99M.jpeg" },
            new Product { Id = 7, Name = "MSI Gaming GF63", Description = "Màn hình 15.6” 144Hz Full HD, GeForce RTX 3050, Intel Core i7-12650H, 8GB DDR4, 512GB SSD, Windows 11, 12UC-887VN, Black", Price = 849, ImageUrl = "https://i.imgur.com/g9lpbET.png" },
            new Product { Id = 8, Name = "MSI Katana 15", Description = "Màn hình 15.6” 144Hz Full HD, GeForce RTX 4060, Intel Core i7-13620H, 16GB DDR4, 1TB SSD, Windows 11, B13VFK-676VN, Black", Price = 999, ImageUrl = "https://i.imgur.com/txwY9tX.jpeg" },
            new Product { Id = 9, Name = "MSI Cyborg 15", Description = "Màn hình 15.6” 144Hz Full HD, GeForce RTX 4050, Intel Core i5-12450H, 8GB DDR4, 512GB SSD, Windows 11, A12VE-412VN, Black", Price = 949, ImageUrl = "https://i.imgur.com/UzHKphc.png" },
            //Pc
            new Product { Id = 10, Name = "PC Core I9-14900K/VGA RTX 4090", Description = "Intel Core i9-14900K, GeForce RTX 4090, 16GB DDR4, 2TB SSD, Black", Price = 1999, ImageUrl = "https://i.imgur.com/hjFLr4C.jpeg" },
            new Product { Id = 11, Name = "PC Core I7-14700K/VGA RTX 3060", Description = "Intel Core i7-14700K, GeForce RTX 3060, 16GB DDR4, 1TB SSD, White", Price = 1690, ImageUrl = "https://i.imgur.com/Lms72L9.jpeg" },
            new Product { Id = 12, Name = "PC Core I7-14700F/VGA RTX 3060", Description = "Intel Core i7-14700F, GeForce RTX 4080, 16GB DDR4, 2TB SSD, Black", Price = 1799, ImageUrl = "https://i.imgur.com/COEE7fi.jpeg" },
            new Product { Id = 13, Name = "PC Core I9-14900K/VGA RTX 4090", Description = "Intel Core i9-14900K, GeForce RTX 4090, 32GB DDR4, 2TB SSD, Black", Price = 2190, ImageUrl = "https://i.imgur.com/n6jFSQu.jpeg" },
            new Product { Id = 14, Name = "PC Core I7-14700F/VGA RTX 3060", Description = "Intel Core i7-14700F, GeForce RTX 3060, 16GB DDR4, 1TB SSD, Black", Price = 1690, ImageUrl = "https://i.imgur.com/Fu9k2Hb.jpeg" },
            new Product { Id = 15, Name = "PC Core I5-14400F/VGA RTX 3050", Description = "Intel Core i5-14400F, GeForce RTX 3050, 16GB DDR4, 1TB SSD, Black", Price = 1690, ImageUrl = "https://i.imgur.com/UUSdVKX.jpeg" },
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return products;
            }

            return products.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
        }
    }
}
