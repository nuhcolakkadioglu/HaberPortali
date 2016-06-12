using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Data.Model
{
    [Table("Rol")]
   public class Rol:Base
    {
        public string RolAdi { get; set; }
    }
}
