using Bussiness_Logic.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Providers
    {

        [Required]
        public int Id_Providers { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "No puede exceder 10 digitos")]
        public string Identification { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "No puede exceder 3 caracteres")]
        public string TypeIdentification { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string ProviderName { get; set; }

        [Required]
        public ProviderTypeClass.EType PType { get; set; }
    }
}
