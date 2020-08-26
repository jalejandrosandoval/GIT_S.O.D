using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Afiliations
{
    /// <summary>
    /// Model of Afiliations of Lawyer with various properties, like:
    /// * Id_ARL: Int. [PK]
    /// * NameARL: String.
    /// </summary>

    [Serializable]
    public class ARL
    {
        [Key]
        public int Id_ARL { get; set; }

        [Required(ErrorMessage = "* ARL Requerida...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "ARL", Description = "ARL", Prompt = "ARL...")]
        public string NameARL { get; set; }
    }

}