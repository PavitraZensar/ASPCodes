using System.ComponentModel.DataAnnotations;

namespace FinalCodeBase.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string? EmpName { get; set; }    
        public string? Location { get; set; }
        public string? Email { get; set; }
        public string? Phoneno { get; set; }

    }
}
