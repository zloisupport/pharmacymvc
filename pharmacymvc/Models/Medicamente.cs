using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacymvc.Models
{
    public class Medicamente
    {
        [Key]
        public int id { get ; set; }

        [Required]
        public string name { get; set; }
        public int id_provider { get; set; }
        public int id_category { get; set; }
        public DateTime extanted_date { get; set; }
        public bool rezept { get; set; }

    }
}
