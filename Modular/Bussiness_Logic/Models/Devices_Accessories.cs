using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]
    public class Devices_Accessories
    {
        [Key]
        public int Id_CV_Devices { get; set; }

        [Required(ErrorMessage = "* Seleccione un Estado...")]
        [Display(Name = "Estado", Description = "Estado", Prompt = "Estado...")]
        public bool StatusDevices { get; set; }

        public ICollection<CV_Devices> CV_Devices { get; set; }

    }
}
