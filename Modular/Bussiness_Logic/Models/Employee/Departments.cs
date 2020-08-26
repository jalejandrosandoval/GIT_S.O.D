using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Employee
{

    [Serializable]
    public class Departments
    {
        [Key]
        public int Id_Departments { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Departamento", Description = "Tipo Departamento", Prompt = "Tipo Departamento...")]
        public string DepartmentsName { get; set; }

        public ICollection<Employees> Employees { get; set; }

    }

}