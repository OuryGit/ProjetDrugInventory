using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugInvortoryDesktop.Models
{
    class archive
    {
        [Key]
        public string IdPlante { get; set; }
        public string EtatSante { get; set; }
        public DateTime DateAjout { get; set; }
        public string Provenance { get; set; }
        public string Description { get; set; }
        public string Stade { get; set; }
        public string Entreposage { get; set; }
    }
}
