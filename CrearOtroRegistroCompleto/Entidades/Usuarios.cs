using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrearOtroRegistroCompleto.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
        public string ConfirmarClave { get; set; }
        public float CostoHora { get; set; }

        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public virtual Roles rol{ get; set; }
    }
}
