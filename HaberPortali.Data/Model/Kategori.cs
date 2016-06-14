using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Data.Model
{
    [Table("Kategori")]
    public class Kategori : Base
    {
        public string KategoriAdi { get; set; }

        public int ParentID { get; set; }

        public string Url { get; set; }

        public virtual ICollection<Haber> Haber { get; set; }

    }
}
