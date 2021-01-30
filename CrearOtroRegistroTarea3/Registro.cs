using CrearOtroRegistroTarea3.DAL;
using CrearOtroRegistroTarea3.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearOtroRegistroTarea3
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        public static bool Existe(string descripcion)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.Descripcion == descripcion);
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

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.RolId == id);
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

        public static bool ExisteUsuario(int id)
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
            bool interruptor = false;
            Contexto contexto = new Contexto();

            try
            {
                var usuarios = contexto.Usuarios.Find(id);

                if (usuarios != null)
                {
                    contexto.Usuarios.Remove(usuarios);//Se elimina la entidad
                    interruptor = contexto.SaveChanges() > 0;
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
            return interruptor;
        }

        public static bool EliminarRol(int id, string descripcion)
        {
            bool interruptor = false;
            Contexto contexto = new Contexto();

            try
            {
                var rol = contexto.Roles.Find(id);

                if (rol != null)
                {
                    if (descripcion == rol.Descripcion)
                    {
                        contexto.Roles.Remove(rol);//Se elimina la entidad
                        interruptor = contexto.SaveChanges() > 0;
                    }
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
            return interruptor;
        }

        
        public static Roles BuscarRol(int id)
        {
            Contexto contexto = new Contexto();
            Roles roles = new Roles();

            try
            {
                roles = contexto.Roles.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return roles;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Roles rol = new Roles();
            Usuarios usuarios = new Usuarios();

            if (usuarioIdTextBox.Text == "" || rolIdTextBox.Text == "" || aliasTextBox.Text == "" || nombresTextBox.Text == "" ||
                 claveTextBox.Text == "" || emailTextBox.Text == "" || DescripcionComboBox.Text == "")
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdTextBox, "Campo obligatorio");
                errorProvider1.SetError(rolIdTextBox, "Campo obligatorio");
                errorProvider1.SetError(aliasTextBox, "Campo obligatorio");
                errorProvider1.SetError(nombresTextBox, "Campo obligatorio");
                errorProvider1.SetError(claveTextBox, "Campo obligatorio");
                errorProvider1.SetError(emailTextBox, "Campo obligatorio");
                errorProvider1.SetError(DescripcionComboBox, "Campo obligatorio");
            }

            else
            {
                //Verificamos que no exista un id igual, 
                //en caso de que exista, no se guarda
                if (Existe(DescripcionComboBox.Text))
                {
                    if (ExisteUsuario(Convert.ToInt32(usuarioIdTextBox.Text)) || Existe(Convert.ToInt32(rolIdTextBox.Text)))
                    {
                        Eliminar(Convert.ToInt32(usuarioIdTextBox.Text));
                        EliminarRol(Convert.ToInt32(rolIdTextBox.Text), DescripcionComboBox.Text);
                        usuarios.UsuarioId = Convert.ToInt32(usuarioIdTextBox.Text);
                        usuarios.Alias = aliasTextBox.Text;
                        usuarios.Email = emailTextBox.Text;
                        usuarios.Clave = claveTextBox.Text;
                        usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value;
                        usuarios.Activo = activoCheckBox.Checked;
                        usuarios.Nombres = nombresTextBox.Text;
                        usuarios.RolId = Convert.ToInt32(rolIdTextBox.Text);
                        rol.RolId = Convert.ToInt32(rolIdTextBox.Text);
                        rol.FechaCreacion = FechaCreacionDateTimePicker.Value;
                        rol.Descripcion = DescripcionComboBox.Text;
                        contexto.Roles.Add(rol);
                        contexto.Usuarios.Add(usuarios);
                        contexto.SaveChanges();
                        contexto.Dispose();
                        errorProvider1.Clear();
                        MessageBox.Show("Se modificó con éxito");

                    }
                    else
                    {
                        MessageBox.Show("Rol existente");
                        errorProvider1.SetError(DescripcionComboBox, "Rol existente");
                    }

                }
                else
                {
                    usuarios.UsuarioId = Convert.ToInt32(usuarioIdTextBox.Text);
                    usuarios.Alias = aliasTextBox.Text;
                    usuarios.Email = emailTextBox.Text;
                    usuarios.Clave = claveTextBox.Text;
                    usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value;
                    usuarios.Activo = activoCheckBox.Checked;
                    usuarios.Nombres = nombresTextBox.Text;
                    usuarios.RolId = Convert.ToInt32(rolIdTextBox.Text);
                    rol.RolId = Convert.ToInt32(rolIdTextBox.Text);
                    rol.FechaCreacion = FechaCreacionDateTimePicker.Value;
                    rol.Descripcion = DescripcionComboBox.Text;
                    contexto.Roles.Add(rol);
                    contexto.Usuarios.Add(usuarios);
                    contexto.SaveChanges();
                    contexto.Dispose();
                    errorProvider1.Clear();
                    MessageBox.Show("El rol se guardó correctamente");
                }

            }
            usuarioIdTextBox.Text = "";
            aliasTextBox.Text = "";
            emailTextBox.Text = "";
            claveTextBox.Text = "";
            nombresTextBox.Text = "";
            rolIdTextBox.Text = "";
            DescripcionComboBox.Text = "";

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles rol = new Roles();
            Contexto contexto = new Contexto();
            BuscarForm ventana = new BuscarForm();
            contexto.Dispose();

            //Igualamos cada objeto grafico de la 2da ventana al valor que queremos que tome
            if (usuarioIdTextBox.Text == "" || rolIdTextBox.Text == "")
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdTextBox, "Campo obligatorio");
                errorProvider1.SetError(rolIdTextBox, "Campo obligatorio");
            }
            else
            {
                if (ExisteUsuario(Convert.ToInt32(usuarioIdTextBox.Text)))
                    rol = BuscarRol(Convert.ToInt32(rolIdTextBox.Text));

                ventana.DescripcionResulTextBox.Text = rol.Descripcion;
                ventana.RolIdResultTextBox.Text = Convert.ToString(rol.RolId);
                ventana.FechaCreacionResultadodateTime.Value = rol.FechaCreacion;
                ventana.Show();

            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (usuarioIdTextBox.Text == "" || rolIdTextBox.Text == "" || DescripcionComboBox.Text == "")
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdTextBox, "Campo obligatorio");
                errorProvider1.SetError(rolIdTextBox, "Campo obligatorio");
                errorProvider1.SetError(DescripcionComboBox, "Campo obligatorio");
            }
            else
            {
                if (ExisteUsuario(Convert.ToInt32(usuarioIdTextBox.Text)))
                {
                    Eliminar(Convert.ToInt32(usuarioIdTextBox.Text));

                    if (Existe(DescripcionComboBox.Text))
                    {
                        if (Existe(Convert.ToInt32(rolIdTextBox.Text)))
                        {
                            EliminarRol(Convert.ToInt32(rolIdTextBox.Text), DescripcionComboBox.Text);
                            MessageBox.Show("Rol eliminado");
                            errorProvider1.Clear();
                        }

                    }
                }
                else
                    MessageBox.Show("Este rol no existe");
            }


            usuarioIdTextBox.Text = "";
            aliasTextBox.Text = "";
            emailTextBox.Text = "";
            claveTextBox.Text = "";
            nombresTextBox.Text = "";
            rolIdTextBox.Text = "";
            DescripcionComboBox.Text = "";
        }

    }
    
}
