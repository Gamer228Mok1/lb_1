using System.ComponentModel.DataAnnotations;

namespace lb_1.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
