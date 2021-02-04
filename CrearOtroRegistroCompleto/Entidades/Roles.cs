using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrearOtroRegistroCompleto.Entidades
{
    public class Roles
    {
        [Key]

        public int RolId { get; set; }       
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
