using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

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

        public Usuarios()
        {
            UsuarioId = 0;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            Rol = string.Empty;
            Activo = true;
            ConfirmarClave = string.Empty;
            CostoHora = 0.0f;
        }
    }
}
