using Bussiness_Logic.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Users
    {

        [Required]
        public int Id_Users { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "No puede exceder 10 digitos")]
        public string N_Identification { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "No puede exceder 3 caracteres")]
        public string TypeDocument { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "No puede exceder 100 caracteres")]
        [EmailAddress(ErrorMessage = "Ingrese una dirección de correo válida")]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "No puede exceder 10 digitos")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña", Description = "Contraseña", Prompt = "Contraseña...")]
        public string UserPassword { get; set; }

        [Required]
        public StatusClass.EStatus Status { get; set; }

        [Required]
        public UserTypeClass.UType UserType { get; set; }

    }
}
