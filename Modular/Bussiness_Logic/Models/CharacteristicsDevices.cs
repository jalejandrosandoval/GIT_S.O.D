using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]

    public class CharacteristicsDevices
    {
        [Key]
        public int Id_CharacteristicsDevices { get; set; }

        [Required(ErrorMessage = "* Marca Requerida")]
        [Display(Name = "Marca", Description = "Marca", Prompt = "Marca...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string Mark { get; set; }

        [Required(ErrorMessage = "* Modelo Requerida")]
        [Display(Name = "Modelo", Description = "Modelo", Prompt = "Modelo...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string Model { get; set; }

        [Required(ErrorMessage = "* S/N Requerido")]
        [Display(Name = "S/N", Description = "S/N", Prompt = "S/N...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "* Prdocuct Id Requerido")]
        [Display(Name = "Prdocuct Id", Description = "Prdocuct Id", Prompt = "Prdocuct Id...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string Product_ID { get; set; }

        [Required(ErrorMessage = "* MAC Requerida")]
        [Display(Name = "MAC", Description = "MAC", Prompt = "MAC...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string MAC { get; set; }

        [Required(ErrorMessage = "* IP Requerida")]
        [Display(Name = "IP", Description = "IP", Prompt = "IP...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string IP { get; set; }

        [Required(ErrorMessage = "* S.O RequeridO")]
        [Display(Name = "S.O", Description = "S.O", Prompt = "S.O...")]
        [StringLength(100, ErrorMessage = "No puede exceder 100 digitos")]
        public string SO { get; set; }

        [Required(ErrorMessage = "* RAM Requerida")]
        [Display(Name = "RAM", Description = "RAM", Prompt = "RAM...")]
        [StringLength(100, ErrorMessage = "No puede exceder 100 digitos")]
        public string RAM { get; set; }

        [Required(ErrorMessage = "* Procesador RequeridO")]
        [Display(Name = "Procesador", Description = "Procesador", Prompt = "Procesador...")]
        [StringLength(100, ErrorMessage = "No puede exceder 100 digitos")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "* Almacenamiento Requerido")]
        [Display(Name = "Almacenamiento", Description = "Almacenamiento", Prompt = "Almacenamiento...")]
        [StringLength(10, ErrorMessage = "No puede exceder 10 digitos")]
        public string Storage { get; set; }

        [Required(ErrorMessage = "* Tipo de Almacenamiento Requerido")]
        [Display(Name = "Tipo de Almacenamiento", Description = "Tipo de Almacenamiento", Prompt = "Tipo de Almacenamiento...")]
        [StringLength(50, ErrorMessage = "No puede exceder 50 digitos")]
        public string StorageType { get; set; }

        [Required(ErrorMessage = "* Seleccione si tiene o no Tarjeta Gráfica...")]
        [Display(Name = "Tarjeta Gráfica", Description = "Tarjeta Gráfica", Prompt = "Tarjeta Gráfica...")]
        public bool TarGraphicCard { get; set; }

        [Required(ErrorMessage = "* Tipo de Pantalla Requerido")]
        [Display(Name = "Tipo de Pantalla", Description = "Tipo de Pantalla", Prompt = "Tipo de Pantalla...")]
        [StringLength(100, ErrorMessage = "No puede exceder 100 digitos")]
        public string Screen { get; set; }

        [DataType(DataType.Text)]
        public string Observartions { get; set; }

        public ICollection<CV_Devices> CV_Devices { get; set; }

    }
}
