using System.ComponentModel.DataAnnotations;

namespace WebMascotas.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Número de Documento")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}