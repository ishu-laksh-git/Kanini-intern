namespace pizzaAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public string? Size { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
    }
}
