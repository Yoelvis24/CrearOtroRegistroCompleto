using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrearOtroRegistroCompleto.Entidades;
using System.Collections.Generic;
using System.Text;

namespace CrearOtroRegistroCompleto.DAL
{
    public class Contexto : DbContext
    {
        
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionUsuarios.Db");
        }
    }
}
