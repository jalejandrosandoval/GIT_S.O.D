using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class UsersType
    {
        [Key]
        public int Id_UsersType { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Tipo Usuario", Description = "Tipo Usuario", Prompt = "Tipo Usuario...")]
        public string UsersTypeName { get; set; }

        public virtual List<Users> Users { get; set; }
    }
}

