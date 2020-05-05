using Bussiness_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Equipment
    {
        [Required]
        public int Id_Equipment { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No puede exceder 20 digitos")]
        public string Equipment_Code { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No puede exceder 20 digitos")]
        public string Equipement_Internal_Code { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string Equipment_Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string Equipment_TradeMark { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "No puede exceder los 30 caracteres")]
        public string Equipment_SN { get; set; }

        [Required]
        public EquipmentTypeClass.E_EquipmentType EquipmentType  { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "No puede exceder los 5000 caracteres")]
        public string Equipment_Observations { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Equipment_Warranty { get; set; }
    }
}
