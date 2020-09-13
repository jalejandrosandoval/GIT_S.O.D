using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{

    [Serializable]
    public class Ubication
    {
        //Primary Key 
        [Key]
        public int Id_Ubication { get; set; }

        [Required]
        [StringLength(100)]
        public string UbicationName { get; set; }

    }
}
