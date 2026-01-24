namespace SendLove.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Occasion { get; set; }   // Birthday, MothersDay, etc.
        public string Section { get; set; }    // Cake, Flowers, SoftToys, Cards...
        public string Gender { get; set; }     // Her, Him, Any

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
