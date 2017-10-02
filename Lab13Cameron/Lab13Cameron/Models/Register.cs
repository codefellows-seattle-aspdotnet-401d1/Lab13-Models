using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13Cameron.Models
{
    public class Register
    {
        public int ID { get; set; }
        public string MC { get; set; }
        public string Hometown { get; set; }
        public int Albums { get; set; }
        [Display(Name = "1st Album")]
        [DataType(DataType.Date)]
        public DateTime FirstAlbum { get; set; }
    }
}
