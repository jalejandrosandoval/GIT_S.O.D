using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Col
{
    [Serializable]

    public class DepartmentsCol
    {
        [Key]
        public int Id_Departments { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Departamento de Colombia", Description = "Departamento de Colombia", Prompt = "Departamento de Colombia...")]
        public string DepartmentsName { get; set; }

        public ICollection<CitiesCol> CitiesCol { get; set; }

    }
}