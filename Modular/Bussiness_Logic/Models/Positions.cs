using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Positions
    {
        [Key]
        public int Id_Positions { get; set; }

        [Required(ErrorMessage = "* Nombre del Cargo Requerido...")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [Display(Name = "Nombre del Cargo", Description = "Nombre del Cargo", Prompt = "Nombre del Cargo...")]
        public string UPositionsTypeName { get; set; }

        public ICollection<Users> Users { get; set; }

        public ICollection<CV_Devices> CV_Devices { get; set; }

    }

}
