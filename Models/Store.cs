using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace challenge_back_end.Models
{
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre comercial es requerido.")]
        [MaxLength(200, ErrorMessage = "La razón social de la empresa debe tener como máximo 200 caracteres.")]
        public string BusinessName { get; set; }
        [MaxLength(200, ErrorMessage = "El nombre comercial de la empresa tener como máximo 200 caracteres.")]
        public string? TradeName { get; set; }
        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "El formato del correo no es correcto.")]
        [MaxLength(1000, ErrorMessage = "El email debe tener como máximo 100 caracteres.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La dirección es requerida.")]
        [MaxLength(200, ErrorMessage = "La dirección de la empresa debe tener como máximo 200 caracteres.")]
        public string? Address { get; set; }
        public int ValidityTime { get; set; }
        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        public DateTime StartDate { get; set; }

    }
}
