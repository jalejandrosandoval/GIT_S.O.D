using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Users
    {
        [Key]
        public int Id_Users { get; set; }

        [Required(ErrorMessage = "* Número de Identifiació Requerido...")]
        [StringLength(10, ErrorMessage = "No puede exceder 10 digitos")]
        [RegularExpression("([0-9]+)", ErrorMessage = "* No. Identificación Incorrecto...")]
        [Display(Name = "Número Documento", Description = "Número de Documento", Prompt = "Número de Identificación...")]
        public string N_Identification { get; set; }

        [Required(ErrorMessage = "* Tipo de Documento Requerido...")]
        [StringLength(5, ErrorMessage = "No puede exceder 5 caracteres")]
        [Display(Name = "Tipo Documento", Description = "Tipo Documento", Prompt = "Tipo Documento...")]
        public string TypeDocument { get; set; }

        [Required(ErrorMessage = "* Nombres Requeridos...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Nombres", Description = "Primer y Segundo Nombre...", Prompt = "Primer y Segundo Nombre...")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Apellidos Requeridos...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Apellidos", Description = "Primer y Segundo Apellido...", Prompt = "Primer y Segundo Apellido...")]
        public string LastName { get; set; }

        [StringLength(10, ErrorMessage = "No puede exceder 10 caracteres")]
        [Display(Name = "Nombre de Usuario")]
        public string Username { get; set; }

        [StringLength(18, ErrorMessage = "Debe tener al menos 6 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña", Description = "Contraseña", Prompt = "Contraseña...")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "* Seleccione un Estado...")]
        [Display(Name = "Estado", Description = "Estado", Prompt = "Estado...")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "* Seleccione un Tipo...")]
        [Display(Name = "Tipo de Usuario", Description = "Tipo de Usuario", Prompt = "Tipo de Usuario...")]
        public int Id_UsersType { get; set; }
        public virtual UsersType UserType { get; set; }
        public List<Lending> Lendings { get; set; }
        public List<Mantenaince> Mantenainces { get; set; }

    }
}
