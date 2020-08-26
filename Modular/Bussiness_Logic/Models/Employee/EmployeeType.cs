using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Employee
{

    /// <summary>
    /// Model of EmployeeType of Lawyer with various properties, like:
    /// * Id_EmployeeType: Int. [PK]
    /// * EmployeeTypeName: string.
    /// </summary>

    [Serializable]
    public class EmployeeType
    {
        [Key]
        public int Id_EmployeeType { get; set; }

        [Required(ErrorMessage = "* Nombre del Cargo Requerido...")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [Display(Name = "Nombre del Cargo", Description = "Nombre del Cargo", Prompt = "Nombre del Cargo...")]
        public string EmployeeTypeName { get; set; }

    }

}