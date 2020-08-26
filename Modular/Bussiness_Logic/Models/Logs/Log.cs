using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Logs
{
    /// <summary>
    /// Model of Log with various properties, like:
    /// * Id_Logs: Int.
    /// * LogType: String.
    /// * LogDescription: String.
    /// </summary>

    [Serializable]
    public class Log
    {
        [Key]
        public int Id_Logs { get; set; }

        [Required(ErrorMessage = "* Tipo de Log Requerido...")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Tipo de Log", Description = "Tipo de Log...", Prompt = "Tipo de Log Nombre...")]
        public string LogType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LogDescription { get; set; }

        [Required(ErrorMessage = "* Seleccione un Usuario...")]
        [Display(Name = "Usuario", Description = "Usuario", Prompt = "Usuario...")]
        public int IdUserLog { get; set; }

        //public Users UserLog { get; set; }


    }
}
