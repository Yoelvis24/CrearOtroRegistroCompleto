using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace CrearOtroRegistroTarea3.Entidades
{
    public class Roles
    {
        [Key]

        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        public Roles()
        {
            RolId = 0;
            FechaCreacion = DateTime.Now;
            Descripcion = string.Empty;
        }
    }
}
