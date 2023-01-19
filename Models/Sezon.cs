using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Magazin.Models
{
    public class Sezon
    {
        public int ID { get; set; }
        [Display(Name = "Nume sezon")]
        public string NumeSezon { get; set; }
        public ICollection<Sezon>? Sezoane { get; set; }
    }
}
