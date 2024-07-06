namespace OnlinePCShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSelected { get; set; }
        public string Brand { get; internal set; }
        public int Quantity { get; internal set; }
    }
}
