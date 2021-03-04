using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace CrearRegistroConDetalle.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public bool EsActivo { get; set; }
        public string Descripcion { get; set; }

        public Roles()
        {
            RolId = 0;
            EsActivo = true;
            Descripcion = string.Empty;

            RolesDetalle = new List<RolesDetalle>();
        }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }
    }
}
