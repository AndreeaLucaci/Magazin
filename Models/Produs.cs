using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Magazin.Models
{
    public class Produs
    {
        public int ID { get; set; }

        public string Nume { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [Display(Name = "Marime Haina")]
        public string Marime { get; set; }
        [Display(Name = "Culoare Haine")]
        public string Culoare { get; set; }

        public int ProducatorID { get; set; }
        [Display(Name = "Nume Producator")]
        public Producator Producator { get; set; }

        public int MaterialID { get; set; }
        [Display(Name = "Tip Material")]
        public Material Material { get; set; }

        public int SezonID { get; set; }
        [Display(Name = "Sezon")]
        public Sezon Sezon { get; set; }

    }
}
