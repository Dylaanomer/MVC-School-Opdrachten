using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Vak
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Naam { get; set; }

      

        [ForeignKey("Docent")]
       
        public int Docent { get; set; }

        public virtual Docent Docenten { get; set; }

        public ICollection<VakStudent> VakStudent { get; set; }




    }
}
