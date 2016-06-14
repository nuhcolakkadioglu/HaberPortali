using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Data.Model
{
    [Table("Haber")]
    public class Haber : Base
    {

        public string Baslik { get; set; }

        public string KisaAciklama { get; set; }

        public string Aciklama { get; set; }

        public int OkunmaSayisi { get; set; }

        public string Resim { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<Resim> Resims { get; set; }


    }
}
