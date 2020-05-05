using Bussiness_Logic.Models;
using System.ComponentModel.DataAnnotations;

namespace AppWeb_MVC.Models
{
    public class EquipmentViewModel
    {

        [Key]
        public int Id_Equipment { get; set; }

        [Required(ErrorMessage = "* Codigo Requerido")]
        [StringLength(100)]
        [Display(Name = "Código", Description = "Número de Código", Prompt = "Código...")]
        public string Equipment_Code { get; set; }

        [Required(ErrorMessage = "* Codigo Requerido")]
        [StringLength(100)]
        [Display(Name = "Código Interno", Description = "Número de Código", Prompt = "Código Interno...")]
        public string Equipement_Internal_Code { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "* Nombre Requerido...")]
        [Display(Name = "Nombre del Equipo", Description = "Nombre del Equipo...", Prompt = "Nombre del Equipo...")]
        public string Equipment_Name { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "* Marca Requerida...")]
        [Display(Name = "Nombre de la Marca", Description = "Nombre de la Marca...", Prompt = "Nombre de la Marca...")]
        public string Equipment_TradeMark { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "* Número de Serial Requerido...")]
        [Display(Name = "S/N", Description = "Número Serial...", Prompt = "Número Serial...")]
        public string Equipment_SN { get; set; }

        [Required(ErrorMessage = "* Tipo de Equipo Requerido")]
        [Display(Name = "Usuario")]
        public string Equipment_Type { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Observaciones", Description = "Observaciones", Prompt = "Observaciones...")]
        public string Equipment_Observations { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "* Garantía Requerida...")]
        [Display(Name = "Garantía", Description = "Garantía", Prompt = "Garantía...")]
        public string Equipment_Warranty { get; set; }

    }
}
