using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace challenge_back_end.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido.")]
        [MaxLength(20, ErrorMessage = "El nombre debe tener como máximo 20 caracteres.")]
        public string Name { get; set; }
        [MaxLength(20, ErrorMessage = "El apellido debe tener como máximo 20 caracteres.")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "El formato del correo no es correcto.")]
        [MaxLength(1000, ErrorMessage = "El email debe tener como máximo 100 caracteres.")]
        public string Email { get; set; }
        [MaxLength(100, ErrorMessage = "La dirección debe tener como máximo 100 caracteres.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "La edad es requerida.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        public DateTime BirthDate { get; set; }
    }
}
