using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace challenge_back_end.Models
{
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string BusinessName { get; set; }
        [MaxLength(200)]
        public string? TradeName { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Address { get; set; }
        [MaxLength(2)]
        public int Age { get; set; }
        [Required]
        public DateTime StartDate { get; set; }

    }
}
