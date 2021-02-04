using System;
using CrearOtroRegistroCompleto.DAL;
using CrearOtroRegistroCompleto.Entidades;
using CrearOtroRegistroCompleto.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearOtroRegistroCompleto
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();

            //cambiar formato de la fecha
            FechaIngresoDateTimePicker.Format = DateTimePickerFormat.Custom;
            FechaIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider1.Clear();

            if (usuarioIdNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(usuarioIdNumericUpDown, "Campo obligatorio");
                paso = false;
            }

            if (nombresTextBox.Text == "")
            {
                errorProvider1.SetError(nombresTextBox, "Campo obligatorio");
                paso = false;
            }

            if (claveTextBox.Text == "")
            {
                errorProvider1.SetError(claveTextBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text == "")
            {
                errorProvider1.SetError(confirmarTextBox, "Campo obligatorio");
                paso = false;
            }

            if (emailTextBox.Text == "")
            {
                errorProvider1.SetError(emailTextBox, "Campo obligatorio");
                paso = false;
            }

            if (rolComboBox.Text == "")
            {
                errorProvider1.SetError(rolComboBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                errorProvider1.SetError(confirmarTextBox, "Claves no coinciden");
                paso = false;
            }
            return paso;
        }

        private void LlenarCampos(Usuarios usuarios)
        {
            usuarioIdNumericUpDown.Value = usuarios.UsuarioId;
            nombresTextBox.Text = usuarios.Nombres;
            aliasTextBox.Text = usuarios.Alias;
            emailTextBox.Text = usuarios.Email;
            confirmarTextBox.Text = usuarios.ConfirmarClave;
            FechaIngresoDateTimePicker.Value = usuarios.FechaIngreso;
            costoTextBox.Text = Convert.ToString(usuarios.CostoHora);
            claveTextBox.Text = usuarios.Clave;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = Convert.ToInt32(usuarioIdNumericUpDown.Value);
            usuarios.Alias = aliasTextBox.Text;
            usuarios.Email = emailTextBox.Text;
            usuarios.Clave = claveTextBox.Text;
            usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value;
            usuarios.Activo = activoCheckBox.Checked;
            usuarios.Nombres = nombresTextBox.Text;
            usuarios.ConfirmarClave = confirmarTextBox.Text;
            usuarios.CostoHora = Convert.ToSingle(costoTextBox.Text);
            usuarios.Rol = rolComboBox.Text;

            return usuarios;
        }


        public void Limpiar()
        {
            usuarioIdNumericUpDown.Value = 0;
            aliasTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            claveTextBox.Text = string.Empty;
            nombresTextBox.Text = string.Empty;
            confirmarTextBox.Text = string.Empty;
            rolComboBox.Text = string.Empty;
            costoTextBox.Text = string.Empty;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            errorProvider1.Clear();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            Contexto contexto = new Contexto();
            BuscarForm ventana = new BuscarForm();
            contexto.Dispose();

            //Igualamos cada objeto grafico de la 2da ventana al valor que queremos que tome
            if (usuarioIdNumericUpDown.Value == 0)
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdNumericUpDown, "Campo obligatorio");
            }
            else
            {
                if (UsuarioBLL.Existe(Convert.ToInt32(usuarioIdNumericUpDown.Value)))
                {
                    usuarios = UsuarioBLL.Buscar(Convert.ToInt32(usuarioIdNumericUpDown.Value));
                    ventana.UsuarioIdResultTextBox.Text = Convert.ToString(usuarios.UsuarioId);
                    ventana.NombresResultTextBox.Text = usuarios.Nombres;
                    ventana.AliasResultTextBox.Text = usuarios.Alias;
                    ventana.EmailResultTextBox.Text = usuarios.Email;
                    ventana.ConfirmarResultTextBox.Text = usuarios.ConfirmarClave;
                    ventana.FechaIngresoResultdateTime.Value = usuarios.FechaIngreso;
                    ventana.CostoResultTextBox.Text = Convert.ToString(usuarios.CostoHora);
                    ventana.ActivoResultTextBox.Text = Convert.ToString(usuarios.Activo);
                    ventana.ClaveResultTextBox.Text = usuarios.Clave;
                    ventana.RolResultTextBox.Text = usuarios.Rol;
                    ventana.Show();
                }
                else 
                {
                    MessageBox.Show("Este usuario no existe");
                }
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios = new Usuarios();

            if (usuarioIdNumericUpDown.Value == 0 || confirmarTextBox.Text == "" || aliasTextBox.Text == "" || nombresTextBox.Text == "" ||
                 claveTextBox.Text == "" || emailTextBox.Text == "" || rolComboBox.Text == "" || costoTextBox.Text == "")
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdNumericUpDown, "Campo obligatorio");
                errorProvider1.SetError(confirmarTextBox, "Campo obligatorio");
                errorProvider1.SetError(aliasTextBox, "Campo obligatorio");
                errorProvider1.SetError(nombresTextBox, "Campo obligatorio");
                errorProvider1.SetError(claveTextBox, "Campo obligatorio");
                errorProvider1.SetError(emailTextBox, "Campo obligatorio");
                errorProvider1.SetError(rolComboBox, "Campo obligatorio");
                errorProvider1.SetError(costoTextBox, "Campo obligatorio");
            }
            else
            {
                //Verificamos que no exista un id igual, 
                //en caso de que exista, no se guarda
                if (UsuarioBLL.Existe(Convert.ToInt32(usuarioIdNumericUpDown.Value)))
                {
                    UsuarioBLL.Eliminar(Convert.ToInt32(usuarioIdNumericUpDown.Value));

                    usuarios.UsuarioId = Convert.ToInt32(usuarioIdNumericUpDown.Value);
                    usuarios.Alias = aliasTextBox.Text;
                    usuarios.Email = emailTextBox.Text;
                    usuarios.Clave = claveTextBox.Text;
                    usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value;
                    usuarios.Activo = activoCheckBox.Checked;
                    usuarios.Nombres = nombresTextBox.Text;
                    usuarios.ConfirmarClave = confirmarTextBox.Text;
                    usuarios.CostoHora = Convert.ToSingle(costoTextBox.Text);
                    usuarios.Rol = rolComboBox.Text;

                    contexto.Usuarios.Add(usuarios);
                    contexto.SaveChanges();
                    contexto.Dispose();
                    errorProvider1.Clear();
                    MessageBox.Show("Se modificó con éxito");
                }
                else
                {
                    usuarios.UsuarioId = Convert.ToInt32(usuarioIdNumericUpDown.Value);
                    usuarios.Alias = aliasTextBox.Text;
                    usuarios.Email = emailTextBox.Text;
                    usuarios.Clave = claveTextBox.Text;
                    usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value;
                    usuarios.Activo = activoCheckBox.Checked;
                    usuarios.Nombres = nombresTextBox.Text;
                    usuarios.ConfirmarClave = confirmarTextBox.Text;
                    usuarios.CostoHora = Convert.ToSingle(costoTextBox.Text);
                    usuarios.Rol = rolComboBox.Text;
                    
                    contexto.Usuarios.Add(usuarios);
                    contexto.SaveChanges();
                    contexto.Dispose();
                    errorProvider1.Clear();
                    MessageBox.Show("Se guardó correctamente");
                }
            }
           
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(usuarioIdNumericUpDown.Value == 0)
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdNumericUpDown, "Campo obligatorio");
            }
            else
            {
                if (UsuarioBLL.Eliminar(Convert.ToInt32(usuarioIdNumericUpDown.Value)))
                    MessageBox.Show("Usuario eliminado");
                else
                    MessageBox.Show("Este usuario no existe");
            }

        }
    }
}
