﻿using System;
using System.Collections.Generic;
using System.Text;
using CrearOtroRegistroCompleto.Entidades;
using CrearOtroRegistroCompleto.DAL;
using System.Linq;
using System.Linq.Expressions;

namespace CrearOtroRegistroCompleto.BLL
{
    public class UsuarioBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuarios.Any(e => e.UsuarioId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //buscar la entidad que se desea eliminar
                var usuarios = contexto.Usuarios.Find(id);

                if (usuarios != null)
                {
                    contexto.Usuarios.Remove(usuarios);//remover la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }


        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios = new Usuarios();

            try
            {
                usuarios = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return usuarios;
        }

        private static bool Insertar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Usuarios.Add(usuarios);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuarios).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Guardar(Usuarios usuarios)
        {
            if (!Existe(usuarios.UsuarioId))
                return Insertar(usuarios);
            else
                return Modificar(usuarios);
        }

    }
}
