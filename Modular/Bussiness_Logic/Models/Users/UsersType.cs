using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Users
{
    /// <summary>
    /// Model of UsersType with various properties, like:
    /// * Id_UsersType: Int.
    /// * UsersTypeName: String.
    /// </summary>

    [Serializable]
    public class UsersType
    {
        //Primary Key 
        [Key]
        public int Id_UsersType { get; set; }

        //The UserType field stores a string to the usertype description
        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Usuario", Description = "Tipo Usuario", Prompt = "Tipo Usuario...")]
        public string UsersTypeName { get; set; }

    }
}