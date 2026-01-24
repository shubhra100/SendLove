using System.ComponentModel.DataAnnotations;

namespace SendLove.Models
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Occasion { get; set; }
        public string Section { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
