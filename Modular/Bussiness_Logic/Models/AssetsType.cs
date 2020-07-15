using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{ 
    [Serializable]

    public class AssetsType
    {

        [Key]
        public int Id_AssetsType { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido Tipo de Activo...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Usuario", Description = "Tipo Activo", Prompt = "Tipo Activo...")]
        public string AssetsTypeName { get; set; }

        public ICollection<Fixed_Assets> Fixed_Assets { get; set; }

    }
}
