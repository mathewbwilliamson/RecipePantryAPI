using System.ComponentModel.DataAnnotations;

namespace RecipePantry.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Cost { get; set; }
        public string UnitType { get; set; }
    }
}