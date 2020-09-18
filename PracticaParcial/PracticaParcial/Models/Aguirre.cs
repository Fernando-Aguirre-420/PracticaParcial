using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaParcial.Models
{

    public enum placeType
    { 
        Panorama,
        Maroon,
        LaRota,
        Duda,
        MiCasa
    }
    public class Aguirre
    {
        [Key]
        public int aguirreID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24,MinimumLength =2)]
        public string Friendofaguirre { get; set; }

        [Required]
        public placeType Place { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name ="Cumpleaños")]
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }