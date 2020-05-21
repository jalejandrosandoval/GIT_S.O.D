using Bussiness_Logic.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace APPWEB.Models
{
    public class UsersViewModel
    {

        [Key]
        public int Id_Users { get; set; }

        [Required(ErrorMessage = "* No. Identificación Incorrecto...")]
        [StringLength(10)]
        [RegularExpression("([0-9]+)", ErrorMessage = "* No. Identificación Incorrecto...")]
        [Display(Name = "Número Documento", Description = "Número de Documento", Prompt = "Número de Identificación...")]
        public string N_Identification { get; set; }

        [Required(ErrorMessage = "* Seleccione un tipo de Identificación...")]
        [StringLength(5)]
        [Display(Name = "Tipo Documento")]
        public string TypeDocument { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "* Nombres Requeridos...")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Nombres", Description = "Primer y Segundo Nombre...", Prompt = "Primer y Segundo Nombre...")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "* Apellidos Requeridos...")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Apellidos", Description = "Primer y Segundo Apellido...", Prompt = "Primer y Segundo Apellido...")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* Correo Eléctronico Requerido")]
        [EmailAddress(ErrorMessage = "Formato de Correo Eléctronico Invalido")]
        [Display(Name = "Correo Electrónico", Description = "Correo Electrónico", Prompt = "Correo Electrónico...")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "* Nombre de Usuario Requerido...")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "* Contraseña Requerida...")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña", Description = "Contraseña", Prompt = "Contraseña...")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "* Seleccione un Estado...")]
        [Display(Name = "Estado")]
        public StatusClass.EStatus Status { get; set; }

        [Required(ErrorMessage = "* Seleccione un Tipo...")]
        [Display(Name = "Tipo de Usuario")]

        public UserTypeClass.UType UserType { get; set; }
    }

}

