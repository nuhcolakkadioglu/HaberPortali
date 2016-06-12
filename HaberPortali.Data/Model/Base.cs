using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Data.Model
{
  public  class Base
    {
        [Key]
        public int ID { get; set; }


        private DateTime? _addDate = DateTime.Now;

        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        private bool _isDeleted = false;
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public DateTime? DeleteDate { get; set; }



    }
}
