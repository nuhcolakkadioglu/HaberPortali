using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaberPortali.Admin.Models.DTO
{
    public class KullaniciVM:BaseVM
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Zorunlu Alan")]
        public string AdSoyad { get; set; }


        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Sifre { get; set; }

    }
}