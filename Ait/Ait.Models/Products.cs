using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Models
{
    public class Products
    {
        [Key]
        public int IdProduct { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Costo { get; set; }
        [MaxLength(200)]
        public string CantidadInventario { get; set; }
    }
}
