using System.ComponentModel.DataAnnotations;

namespace AzureMiniProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? ProductName { get; set; }
        public int Price { get; set; }
        public string? Brand { get; set; }
        public string? ManufactureDate { get; set; }
        public string? ExpirationDate { get; set; }
    }
}
