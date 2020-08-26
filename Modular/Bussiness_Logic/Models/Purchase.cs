using System;
using System.ComponentModel.DataAnnotations;
using Bussiness_Logic.Models.Providers;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Purchase
    {
        [Key]
        public int Id_Purchase { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string PurchaseEvidence { get; set; }

        [Required]
        [StringLength(50)]
        public string NumberInvoice { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string PurchaseDescription { get; set; }

        public int EquipmentId { get; set; }

        public int ProvidersId { get; set; }

        public Equipment Equipments { get; set; }

        //public Providers Providers { get; set; }

    }
}
