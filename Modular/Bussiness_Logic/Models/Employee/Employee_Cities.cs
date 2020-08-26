using Bussiness_Logic.Models.Col;
using Bussiness_Logic.Models.Complements;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Employee
{
    /// <summary>
    /// Model of Employee_Cities with various properties, like:
    /// * Id_Employee_Cities: Int.
    /// * UsersTypeName: String.
    /// </summary>

    [Serializable]

    public class Employee_Cities
    {
        [Key]
        public int Id_Employee_Cities{ get; set; }

        [Required]
        public int IdEmployee { get; set; }

        [Required]
        public Employees Employee { get; set; }

        [Required]
        public int IdCitiesCol { get; set; }

        [Required]
        public CitiesCol CitiesCol { get; set; }

        [Required]
        public int IdTypeCity { get; set; }

        [Required]
        public TypeCity TypeCity { get; set; }

        [Required(ErrorMessage = "* Dirección de Residencia Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Dirección de Residencia", Description = "Dirección de Residencia...", Prompt = "Dirección de Residencia...")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "* Barrio de Residencia Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Barrio de Residencia", Description = "Barrio de Residencia...", Prompt = "Barrio de Residencia...")]
        public string Neighborhood { get; set; }

    }
}
