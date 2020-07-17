using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]

    public class DevicesTypes
    {
        [Key]
        public int Id_DevicesTypes { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Dispositivo", Description = "Tipo Dispositivo", Prompt = "Tipo Dispositivo...")]
        public string DevicesTypesName { get; set; }

        public ICollection<CV_Devices> CV_Devices { get; set; }

    }
}
