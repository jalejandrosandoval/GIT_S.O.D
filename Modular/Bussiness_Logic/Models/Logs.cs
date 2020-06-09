using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]
    public class Logs
    {
        [Key]
        public int Id_Logs { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LogDescription { get; set; }

        public Users Users { get; set; }

    }
}
