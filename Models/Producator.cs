using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Magazin.Models
{
    public class Producator
    {
        public int ID { get; set; }
        [Display(Name = "Nume Producator")]
        public string NumeProducator { get; set; }
        public ICollection<Produs>? Produse { get; set; }
    }
}
