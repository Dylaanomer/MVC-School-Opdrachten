﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Docent
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Voornaam { get; set; }

        [StringLength(40)]
        public string Achternaam { get; set; }

        [ForeignKey("Locatie")]
        [Display(Name = "Locatie")]
        public int LocatieId { get; set; }

        public virtual Locatie Locatie { get; set; }


    }
}
