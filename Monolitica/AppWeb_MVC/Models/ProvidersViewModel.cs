using Bussiness_Logic.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AppWeb_MVC.Models
{
    public class ProvidersViewModel
    {

        [Key]
        public int Id_Providers { get; set; }

        [Required(ErrorMessage = "* No. Identificación Incorrecto...")]
        [StringLength(10)]
        [RegularExpression("([0-9]+)", ErrorMessage = "* No. Identificación Incorrecto...")]
        [Display(Name = "Número Documento", Description = "Número de Documento", Prompt = "Número de Identificación...")]
        public string Identification { get; set; }

        [Required(ErrorMessage = "* Seleccione un tipo de Identificación...")]
        [StringLength(5)]
        [Display(Name = "Tipo Documento")]
        public string TypeIdentification { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "* Nombre Requeridos...")]
        [Display(Name = "Nombres", Description = "Primer y Segundo Nombre...", Prompt = "Primer y Segundo Nombre...")]
        public string ProviderName { get; set; }

        [Required(ErrorMessage = "* Seleccione un Tipo...")]
        [Display(Name = "Tipo de Proveedor")]

        public ProviderTypeClass.EType PType { get; set; }

    }

}
