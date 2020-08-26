using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Afiliations
{
    /// <summary>
    /// Model of Afiliations of Lawyer with various properties, like:
    /// * Id_AFP: Int. [PK]
    /// * NameAFP: String.
    /// </summary>

    [Serializable]
    public class AFP
    {
        [Key]
        public int Id_AFP { get; set; }

        [Required(ErrorMessage = "* AFP Requerida...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "AFP", Description = "AFP", Prompt = "AFP...")]
        public string NameAFP { get; set; }
    }

}