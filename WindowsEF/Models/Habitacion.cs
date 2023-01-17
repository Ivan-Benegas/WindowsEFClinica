using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Habitaciones")]
    public class Habitacion
    {
        [Key]
        public int Id { get; set; }

        public int Numero { get; set; }

        [Required]
        public string Estado { get; set; }

        public string Descripcion { get; set; }

    }
}
