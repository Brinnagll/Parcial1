using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialBrinnaGorena.Models
{
    public enum typecode
    {
        COL = 57,
        BOL = 591,
        ARG = 54,
        CHL = 56,
        BRA = 55
    }
    public class Country
    {

        [Display(Description = "Codigo de llamada")]
        [Required(ErrorMessage = "Debe insertar el codigo")]
        public typecode CallingCodes { get; set; }

        [Required]
        public string alpha3code { get; set; }

        [DisplayName("Region")]
        public string Region { get; set; }
        
        [Key]
        [Required]
        [DisplayName("Pais")]
        [StringLength(30, ErrorMessage = "El campo debe tenr entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }
        
        [DisplayName("Area")]
        public string Area { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un idioma")]
        public string Languages { get; set; }

        [Display(Description = "Bandera")]
        public string Flag { get; set; }
  


    }
}