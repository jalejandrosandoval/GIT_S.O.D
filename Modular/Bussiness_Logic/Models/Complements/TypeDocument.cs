using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Complements
{
    /// <summary>
    /// Model of TypeDocument with various properties, like:
    /// * Id_TypeDocument: Int.
    /// * Name_TypeDocument: String.
    /// </summary>

    [Serializable]
    public class TypeDocument
    {
        [Key]
        public int Id_TypeDocument { get; set; }

        [Required(ErrorMessage = "* Tipo Documento Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Documento", Description = "Tipo Documento", Prompt = "Tipo Documento...")]
        public string Name_TypeDocument { get; set; }
    }
}