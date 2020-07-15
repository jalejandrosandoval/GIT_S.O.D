using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]

    public class Fixed_Assets
    {

        [Key]
        public int Id_Fixed_Assests { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Usuario", Description = "Tipo Usuario", Prompt = "Tipo Usuario...")]
        public string FixedAssetsName { get; set; }

        [Required(ErrorMessage = "* Nombre de la Marca Requerida...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Marca Activo Fijo", Description = "Marca Activo Fijo", Prompt = "Marca Activo Fijo")]
        public string AssetsCharacteristicsMark { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Modelo Activo Fijo", Description = "Modelo Activo Fijo", Prompt = "Modelo Activo Fijo")]
        public string AssetsCharacteristicsModel { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Marca Activo Fijo", Description = "Marca Activo Fijo", Prompt = "Marca Activo Fijo")]
        public string AssetsCharacteristicsSerialNumber { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "ProductId", Description = "ProductId", Prompt = "ProductId")]
        public string AssetsCharacteristicsProductId { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Memoria Ram", Description = "Marca Activo Fijo", Prompt = "Marca Activo Fijo")]
        public string AssetsCharacteristicsMemoryRam { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Almacenamiento", Description = "Almacenamiento", Prompt = "Almacenamiento")]
        public string AssetsCharacteristicsStorage { get; set; }

        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Almacenamiento", Description = "Tipo Almacenamiento", Prompt = "Tipo Almacenamiento")]
        public string AssetsCharacteristicsStorageType { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "No puede exceder los 5000 caracteres")]
        public string AssetsCharacteristics_Others { get; set; }

        [Required(ErrorMessage = "* Seleccione un Tipo...")]
        [Display(Name = "Tipo de Activo Fijo", Description = "Tipo de Activo Fijo", Prompt = "Tipo de Activo Fijo...")]
        public int Id_AssestsType { get; set; }
        public AssetsType AssetsType { get; set; }
    }
}
