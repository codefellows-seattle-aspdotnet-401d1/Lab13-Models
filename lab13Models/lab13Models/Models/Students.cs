using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab13Models.Models
{
    public class Students
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Grade { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

    }
}
