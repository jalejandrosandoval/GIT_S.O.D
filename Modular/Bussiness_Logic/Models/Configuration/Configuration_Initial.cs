using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Configuration
{
    /// <summary>
    /// Model of Configuration_Initial for the configuration general in the page, and this model are various properties, like:
    /// * ID_ConfigInit: Int. [PK].
    /// * NameEnterprise: String.
    /// * PageName: String.
    /// * ImageRoute: String.
    /// </summary>

    [Serializable]
    public class Configuration_Initial
    {
        //Primary Key 
        [Key]
        public int ID_ConfigInit { get; set; }

        //Field NameEnterprise
        [Required]
        [DataType(DataType.Text)]
        public string NameEnterprise { get; set; }

        //Field PageName
        [Required]
        [DataType(DataType.Text)]
        public string PageName { get; set; }

        //Field for the ImageRoute principal in the login
        [Required]
        [DataType(DataType.Text)]
        public string ImageRoute { get; set; }

    }
}