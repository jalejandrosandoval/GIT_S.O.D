using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]
    public class Devices_Mantenaince
    {
        [Key]
        public int Id_DevicesMantenaince { get; set; }

        [Required(ErrorMessage = "* Descripción Requerida...")]
        [DataType(DataType.Text)]
        [Display(Name = "Descripción", Description = "Descripción", Prompt = "Descripción...")]
        public string Description_Mantenaince { get; set; }

        [Required(ErrorMessage = "* Seleccione un Estado...")]
        [Display(Name = "Estado", Description = "Estado", Prompt = "Estado...")]
        public bool Status_Mantenaince { get; set; }

        [Required(ErrorMessage = "* Fecha Requerida...")]
        [DataType(DataType.Date)]
        public DateTime Date_Mantenaince { get; set; }

        [Required(ErrorMessage = "* Observaciones Requeridas...")]
        [DataType(DataType.Text)]
        public string Observartions_Mantenaince { get; set; }

        //public ICollection<CV_Devices> CV_Devices { get; set; }

    }
}
