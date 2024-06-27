using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugInvortoryDesktop.Models
{
    public class plantule
    {

        /*public int SpecialiteId { get; set; }
        public string SpecialiteNom { get; set; }
        public string SpecialiteDescription { get; set; }
*/
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
