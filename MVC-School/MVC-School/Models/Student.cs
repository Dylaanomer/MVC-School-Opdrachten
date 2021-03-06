using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Voornaam { get; set; }

        [StringLength(20)]
        public string Achternaam { get; set; }

        [StringLength(40)]
        public string Adres { get; set; }

        [StringLength(40)]
        public string Woonplaats { get; set; }

        public ICollection<VakStudent> VakStudent { get; set; }


    }
}
