using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Providers
    {

        [Key]
        public int Id_Providers { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "No puede exceder 12 digitos")]
        public string Identification { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "No puede exceder 3 caracteres")]
        public string TypeIdentification { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string ProviderName { get; set; }

        public ProviderType ProviderType { get; set; }

        public List<Purchase> Purchases { get; set; }

    }
}
