using System.ComponentModel.DataAnnotations;

namespace AsynchronousValidationExample.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Le nom est requis.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "L'adresse e-mail est requise.")]
        [EmailAddress(ErrorMessage = "Adresse e-mail invalide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères.")]
        public string Password { get; set; }
    }
}
