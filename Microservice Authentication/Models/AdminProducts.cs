namespace Microservice_Authentication.Models
{
    public class AdminProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }

        public int SellerId { get; set; }
    }
}
