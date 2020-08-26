using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Afiliations
{
    /// <summary>
    /// Model of Afiliations of Lawyer with various properties, like:
    /// * Id_CCF: Int. [PK]
    /// * NameCCF: String.
    /// </summary>

    [Serializable]
    public class CCF
    {
        [Key]
        public int Id_CCF { get; set; }

        [Required(ErrorMessage = "* CCF Requerida...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "CCF", Description = "CCF", Prompt = "CCF...")]
        public string NameCCF { get; set; }
    }

}