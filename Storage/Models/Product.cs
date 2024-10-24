using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(1, 1000000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Orderdate { get; set; } 

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(10)]
        public string Shelf { get; set; }

        [Required]
        public int Count { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
