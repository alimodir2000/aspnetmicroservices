namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public int Quntity { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }

    }
}