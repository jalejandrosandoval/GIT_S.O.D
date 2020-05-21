using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb_MVC.Models
{
    public class LoginViewModel
    {
        [Key]
        [Required(ErrorMessage = "* Correo Eléctronico Requerido")]
        [EmailAddress]
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
