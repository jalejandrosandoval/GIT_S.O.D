using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Complements
{
    /// <summary>
    /// Model of TypeCity with various properties, like:
    /// * Id_TypeCity: Int.
    /// * Name_TypeCity: String.
    /// </summary>

    [Serializable]
    public class TypeCity
    {
        [Key]
        public int Id_TypeCity { get; set; }

        [Required(ErrorMessage = "* Tipo Ciudad Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Ciudad", Description = "Tipo Ciudad", Prompt = "Tipo Ciudad...")]
        public string Name_TypeCity { get; set; }
    }
}