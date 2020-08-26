using Bussiness_Logic.Models.Complements;
using Bussiness_Logic.Models.Employee;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    /// <summary>
    /// Model of Employees with various properties, like:
    /// * Id_Employee: Int.
    /// * FirstName: String.
    /// * LastName: String.
    /// * Id_TypeDocument: Int. [FK] -> Table TypeDocument
    /// </summary>

    [Serializable]
    public class Employees
    {
        [Key]
        public int Id_Employee { get; set; }

        [Required(ErrorMessage = "* Nombres Requeridos...")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Nombres", Description = "Primer y Segundo Nombre...", Prompt = "Primer y Segundo Nombre...")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Apellidos Requeridos...")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Apellidos", Description = "Primer y Segundo Apellido...", Prompt = "Primer y Segundo Apellido...")]
        public string LastName { get; set; }

        [Required]
        public int IdTypeDocument { get; set; }

        [Required]
        public TypeDocument TypeDocument { get; set; }

        [Required(ErrorMessage = "* Número de Documento Requerido...")]
        [StringLength(10, ErrorMessage = "No puede exceder 10 digitos")]
        [RegularExpression("([0-9]+)", ErrorMessage = "* No. Identificación Incorrecto...")]
        [Display(Name = "Número Documento", Description = "Número de Documento", Prompt = "Número de Documento...")]
        public string N_Document { get; set; }

        [Required(ErrorMessage = "* Fecha de Nacimiento Requerida...")]
        [DataType(DataType.Date)]
        public DateTime Date_Birth { get; set; }

        [Required(ErrorMessage = "* Fecha de Expedición del Documento Requerida...")]
        [DataType(DataType.Date)]
        public DateTime Date_ExpeditionDoc { get; set; }

        [Required]
        public int IdStatusCivil { get; set; }

        [Required]
        public StatusCivil StatusCivil { get; set; }

        [Required(ErrorMessage = "* Género Requerido...")]
        [StringLength(20, ErrorMessage = "No puede exceder los 20 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Género", Description = "Género...", Prompt = "Género...")]
        public string Gen { get; set; }

        [Required(ErrorMessage = "* Libreta Militar Requerido...")]
        [Display(Name = "Libreta Militar", Description = "Libreta Militar", Prompt = "Libreta Militar...")]
        public bool MilitaryNotebook { get; set; }

        [StringLength(20, ErrorMessage = "No puede exceder los 20 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Número Libreta Militar", Description = "Número Libreta Militar...", Prompt = "Número Libreta Militar...")]
        public string NumberMilitaryote { get; set; }

        [Required(ErrorMessage = "* Correo Eléctronico Requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Formato de Correo Eléctronico Invalido")]
        [Display(Name = "Correo Electrónico", Description = "Correo Electrónico", Prompt = "Correo Electrónico...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Correo Eléctronico Requerido")]
        [StringLength(2, ErrorMessage = "No puede exceder los 2 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Grupo Sanguíneo", Description = "Grupo Sanguíneo...", Prompt = "Grupo Sanguíneo...")]
        public string GroupBlood { get; set; }

        [Required(ErrorMessage = "* RH Requerido...")]
        [StringLength(2, ErrorMessage = "No puede exceder los 2 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "RH", Description = "RH...", Prompt = "RH...")]
        public string RH { get; set; }

        [Required(ErrorMessage = "* Personas a Cargo Requerido...")]
        [StringLength(2, ErrorMessage = "No puede exceder los 2 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Personas a Cargo", Description = "Personas a Cargo...", Prompt = "Personas a Cargo...")]
        public string PersonsDepends { get; set; }

        [Required(ErrorMessage = "* Hijos Requerido...")]
        [StringLength(2, ErrorMessage = "No puede exceder los 2 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Hijos", Description = "Hijos...", Prompt = "Hijos...")]
        public string Childrens { get; set; }

        [Required(ErrorMessage = "* Nivel de Estudio Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Nivel de Estudio", Description = "Nivel de Estudio...", Prompt = "Nivel de Estudio...")]
        public string Studies { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Estudios En", Description = "Estudios En...", Prompt = "Estudios En...")]
        public string Studies_In { get; set; }

        [Required]
        public int IdEmployeeType { get; set; }
        
        [Required]
        public EmployeeType EmployeeType { get; set; }

        [Required]
        public int IdInternalInformation { get; set; }

        [Required]
        public Internal_Information Internal_Information { get; set; }

    }
}