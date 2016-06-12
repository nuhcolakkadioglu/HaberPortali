using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaberPortali.Data.Model
{
    [Table("Kullanici")]
  public  class Kullanici:Base
    {

        public string AdSoyad { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }

        public virtual Rol Rol { get; set; }

    }
}
