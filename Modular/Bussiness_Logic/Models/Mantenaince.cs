using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]
    public class Mantenaince
    {
        [Key]
        public int Id_Mantenaince { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateMantenaince { get; set; }

        [Required]
        public bool StratusMantenaince { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No puede exceder 20 digitos")]
        public string CodeEquipment { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string DescriptionMantenaince { get; set; }

        [Required]
        public int UsersId { get; set; }

        [Required]
        public int EquipmentId { get; set; }

        public Users Users { get; set; }

        public Equipment Equipments { get; set; }

    }
}
