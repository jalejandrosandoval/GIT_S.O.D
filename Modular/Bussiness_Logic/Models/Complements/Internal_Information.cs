using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Complements
{
    /// <summary>
    /// Model of Internal_Information with various properties, like:
    /// * Id_Internal_Information: Int. [PK]
    /// </summary>

    [Serializable]
    public class Internal_Information
    {

        [Key]
        public int Id_Internal_Information { get; set; }


    }
}
