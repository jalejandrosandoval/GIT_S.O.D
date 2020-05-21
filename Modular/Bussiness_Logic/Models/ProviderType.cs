using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]

    public class ProviderType
    {
        [Key]
        public int Id_ProviderType { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        public string ProviderTypeName { get; set; }
    }
}
