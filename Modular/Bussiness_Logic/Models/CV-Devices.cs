using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]

    public class CV_Devices
    {

        [Key]
        public int Id_CV_Devices { get; set; }

        [Required(ErrorMessage = "* Fecha Requerida...")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "* Seleccione un Usuario...")]
        [Display(Name = "Usuario", Description = "Usuario", Prompt = "Usuario...")]
        public int Id_User { get; set; }

        public Users Users { get; set; }

        [Required(ErrorMessage = "* Seleccione un Departamento...")]
        [Display(Name = "Tipo de Departamento", Description = "Tipo de Departamento", Prompt = "Tipo de Departamento...")]
        public int Id_Departments { get; set; }

        public Departments Departments { get; set; }

        [Required(ErrorMessage = "* Seleccione un Cargo...")]
        [Display(Name = "Cargo", Description = "Tipo de Cargo", Prompt = "Tipo de Cargo...")]
        public int Id_Positions { get; set; }

        public Positions Positions { get; set; }

        [Required(ErrorMessage = "* Seleccione un Tipo...")]
        [Display(Name = "Tipo de Dispositivo", Description = "Tipo de Dispositivo", Prompt = "Tipo de Dispositivo...")]
        public int Id_TypesDevices { get; set; }

        public DevicesTypes DevicesTypes { get; set; }

        [Required(ErrorMessage = "* Nombre Requerido...")]
        [StringLength(50, ErrorMessage = "No puede exceder los 50 caracteres")]
        [Display(Name = "Nombre Dispositivo", Description = "Nombre Dispositivo", Prompt = "Nombre Dispositivo...")]
        public string NameDevice { get; set; }

        [Required(ErrorMessage = "* Seleccione unas Caracteristicas...")]
        [Display(Name = "Caracteristicas", Description = "Caracteristicas", Prompt = "Caracteristicas...")]
        public int Id_Characteristics { get; set; }

        public CharacteristicsDevices CharacteristicsDevices { get; set; }

        [Required(ErrorMessage = "* Seleccione Accesorios...")]
        [Display(Name = "Accesorios", Description = "Accesorios", Prompt = "Accesorios...")]
        public int Id_DevicesAccessories { get; set; }

        public Devices_Accessories Devices_Accessories { get; set; }

        [Required(ErrorMessage = "* Seleccione Mantenimiento...")]
        [Display(Name = "Mantenimiento", Description = "Mantenimiento", Prompt = "Mantenimiento...")]
        public int Id_DevicesMantenaince { get; set; }

        public Devices_Mantenaince Devices_Mantenaince { get; set; }

        [DataType(DataType.Text)]
        public string Observartions { get; set; }

    }

}
