using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace challenge_back_end.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string? LastName { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; }
        [Required]
        [MaxLength(2)]
        public int Age { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
