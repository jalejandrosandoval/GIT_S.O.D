using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Lending
    {

        [Key]
        public int Id_Lending { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateLending  { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No puede exceder 20 digitos")]
        public string CodeEquipment { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string DescriptionMantenaince { get; set; }  

        public int EmployeeId { get; set; }

        public int EquipmentId { get; set; }

        public int UbicationId { get; set; }

        //public Users Users { get; set; }

        public Equipment Equipments { get; set; }

        public Ubication Ubication { get; set; }

    }
}
