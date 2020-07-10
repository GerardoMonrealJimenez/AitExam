using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Models
{
    public class Users
    {
        [Key]
        public int IdUser { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Apellido { get; set; }
        [MaxLength(200)]
        public string Password { get; set; }
        public int? Activo { get; set; }
    }
}
