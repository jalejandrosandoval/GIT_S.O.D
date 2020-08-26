using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Providers
{

    [Serializable]

    public class ProvidersType
    {
        [Key]
        public int Id_ProviderType { get; set; }

        [Required(ErrorMessage = "* Tipo de Proveedor Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo de Proveedor", Description = "Tipo de Proveedor", Prompt = "Tipo de Proveedor...")]
        public string ProvidersTypeName { get; set; }

        public ICollection<Providers> Providers { get; set; }

    }
}
