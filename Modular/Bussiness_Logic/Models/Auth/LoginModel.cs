using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Auth
{
    /// <summary>
    /// Model of LoginModel with various properties, like:
    /// * Username: String.
    /// * UserPassword: String.
    /// * RememberMe: Bool
    /// </summary>

    [Serializable]
    public class LoginModel
    {

        [Required(ErrorMessage = "* Correo Eléctronico Requerido")]
        [Display(Name = "Nombre de Usuario", Description = "Nombre de Usuario", Prompt = "Usuario...")]
        public string Username { get; set; }

        [Key]
        [Required(ErrorMessage = "* Contraseña Requerida")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña", Description = "Contraseña", Prompt = "Contraseña...")]
        public string UserPassword { get; set; }

        [Display(Name = "Recuerdame")]
        public bool RememberMe { get; set; }
    }
}