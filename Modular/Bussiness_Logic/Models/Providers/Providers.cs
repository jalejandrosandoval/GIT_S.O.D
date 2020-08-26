using Bussiness_Logic.Models.Col;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Providers
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

        [Required(ErrorMessage = "* Seleccione un Estado...")]
        [Display(Name = "Estado", Description = "Estado", Prompt = "Estado...")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "* Nombres Persona de Contacto...")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Nombres Persona de Contacto", Description = "Nombres Persona de Contacto...", Prompt = "Nombres Persona de Contacto..")]
        public string NameContact { get; set; }

        [Required(ErrorMessage = "* Correo Eléctronico Requerido")]
        [EmailAddress(ErrorMessage = "Formato de Correo Eléctronico Invalido")]
        [Display(Name = "Correo Electrónico", Description = "Correo Electrónico", Prompt = "Correo Electrónico...")]
        public string EmailContact { get; set; }

        [Required(ErrorMessage = "* Número de Teléfono Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Número de Teléfono", Description = "Número de Teléfono", Prompt = "Número de Teléfono...")]
        public string NumberPhone { get; set; }


        [Required(ErrorMessage = "* Seleccione un Tipo...")]
        [Display(Name = "Tipo de Usuario", Description = "Tipo de Usuario", Prompt = "Tipo de Usuario...")]
        public int Id_ProvidersType { get; set; }

        public ProvidersType ProvidersType { get; set; }

        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [Display(Name = "Número de Teléfono", Description = "Número de Teléfono", Prompt = "Número de Teléfono...")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "* Seleccione una Ciudad...")]
        [Display(Name = "Ciudad de Colombia", Description = "Ciudad de Colombia", Prompt = "Ciudad de Colombia...")]
        public int IdCity { get; set; }
    
        public CitiesCol CitiesCol { get; set; }

        //[Required]
        //[DataType(DataType.Text)]
        //public string Brackets { get; set; }

        //        public List<Purchase> Purchases { get; set; }

    }

}