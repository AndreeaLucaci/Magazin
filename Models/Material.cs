using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Magazin.Models
{
    public class Material
    {
        public int ID { get; set; }
        [Display(Name = "Tip Material")]
        public string NumeMaterial { get; set; }
        public ICollection<Material>? Materiale { get; set; }
    }
}
