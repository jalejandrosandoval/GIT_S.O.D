using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Complements
{
    /// <summary>
    /// Model of StatusCivil with various properties, like:
    /// * Id_StatusCivil: Int.
    /// * Name_StatusCivil: String.
    /// </summary>

    [Serializable]
    public class StatusCivil
    {
        [Key]
        public int Id_StatusCivil { get; set; }

        [Required(ErrorMessage = "* Estado Civl Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Estado Civl", Description = "Estado Civl", Prompt = "Estado Civl...")]
        public string Name_StatusCivil { get; set; }
    }
}