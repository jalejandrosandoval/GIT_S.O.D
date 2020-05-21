using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]
    public class EquipmentType
    {
        [Key]
        public int Id_EquipmentType { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string EquipmentTypeName { get; set; }

    }
}