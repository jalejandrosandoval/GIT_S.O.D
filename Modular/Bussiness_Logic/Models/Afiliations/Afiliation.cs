using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models.Afiliations
{
    /// <summary>
    /// Model of Afiliations of Lawyer with various properties, like:
    /// * Id_Afiliations: Int. [PK]
    /// * IdEmployee: Int. [FK]-> Table Employee
    /// * IdEPS: Int. [FK]-> Table EPS
    /// * IdARL: Int. [FK]-> Table ARL
    /// * IdAFP: Int. [FK]-> Table AFP
    /// * IdCCF: Int. [FK]-> Table CCF
    /// </summary>

    [Serializable]
    public class Afiliation
    {
        [Key]
        public int Id_Afiliations { get; set; }

        [Required]
        public int IdEmployee { get; set; }

        [Required]
        public Employees Employees { get; set; }

        [Required]
        public int IdEPS { get; set; }

        [Required]
        public EPS EPS { get; set; }

        [Required]
        public int IdARL { get; set; }

        [Required]
        public ARL ARL { get; set; }

        [Required]
        public int IdAFP { get; set; }

        [Required]
        public AFP AFP { get; set; }

        [Required]
        public int IdCCF { get; set; }

        [Required]
        public CCF CCF { get; set; }

    }
}