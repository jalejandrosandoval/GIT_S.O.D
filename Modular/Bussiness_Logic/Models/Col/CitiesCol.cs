using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Col
{
    [Serializable]
    public class CitiesCol
    {
        [Key]
        public int Id_CitiesCol { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Ciudad de Colombia", Description = "Ciudad de Colombia", Prompt = "Ciudad de Colombia...")]
        public string CityName { get; set; }

        public int Id_DepartmentsCols { get; set; }

        public DepartmentsCol DepartmentsCol { get; set; }
    }
}