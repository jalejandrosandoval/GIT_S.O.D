using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Equipment
    {
 
        [Key]
        public int Id_Equipment { get; set; }

        [Required(ErrorMessage = "* Codigo Requerido")]
        [Display(Name = "Código Interno", Description = "Número de Código", Prompt = "Código Interno...")]
        [StringLength(30, ErrorMessage = "No puede exceder 30 digitos")]
        public string Equipement_Internal_Code { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string Equipment_Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string Equipment_TradeMark { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No puede exceder 20 digitos")]
        public string Equipment_Model { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "No puede exceder los 30 caracteres")]
        public string Equipment_SN { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "No puede exceder los 5000 caracteres")]
        public string Equipment_Observations { get; set; }

        [Required]
        public bool Equipment_Status { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Equipment_Warranty { get; set; }

        public EquipmentType EquipmentType { get; set; }

        public List<Lending> Lendings{ get; set; }

        public List<Mantenaince> Mantenainces { get; set; }

        public List<Purchase> Purchases { get; set; }

    }
}
