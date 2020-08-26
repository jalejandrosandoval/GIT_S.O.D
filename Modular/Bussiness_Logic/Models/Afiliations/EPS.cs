using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Afiliations
{
    /// <summary>
    /// Model of Afiliations of Lawyer with various properties, like:
    /// * Id_EPS: Int. [PK]
    /// * NameEPS: String.
    /// </summary>
    
    [Serializable]

    public class EPS
    {
        [Key]
        public int Id_EPS { get; set; }

        [Required(ErrorMessage = "* EPS Requerida...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "EPS", Description = "EPS", Prompt = "EPS...")]
        public string NameEPS { get; set; }
    }
}