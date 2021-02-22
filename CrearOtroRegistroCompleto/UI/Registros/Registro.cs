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
            FechaIngresoDateTimePicker.Value = usuarios.FechaIngreso;
            claveTextBox.Text = usuarios.Clave;
            activoCheckBox.Checked = usuarios.Activo;
            rolComboBox.SelectedIndex = usuarios.RolId;
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
            usuarios.RolId = rolComboBox.SelectedIndex;

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
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            activoCheckBox.Checked = false;
            errorProvider1.Clear();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuarioBLL.Buscar((int)usuarioIdNumericUpDown.Value);
            return (usuarios != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuarios = new Usuarios();
            int.TryParse(usuarioIdNumericUpDown.Text, out id);

            Limpiar();

            usuarios = UsuarioBLL.Buscar(id);

            if(usuarios != null)
            {
                MessageBox.Show("Usuario encontrado");
                LlenarCampos(usuarios);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenarClase();

            //determinar si es guardar o modificar
            if (usuarioIdNumericUpDown.Value != 0)
                paso = UsuarioBLL.Guardar(usuarios);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe");
                    return;
                }
                paso = UsuarioBLL.Modificar(usuarios);
            }

            //Informar el resultado
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se ha guardado correctamente");
            }
            else
                MessageBox.Show("No fue posible guardar");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(usuarioIdNumericUpDown.Text, out id);

            Limpiar();

            if(UsuarioBLL.Eliminar(id))
                MessageBox.Show("Usuario eliminado");
            else
                errorProvider1.SetError(usuarioIdNumericUpDown, "Este usuario no existe");
            
        }

        private void RolesButton_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroRoles registrosRoles = new UI.Registros.RegistroRoles();
            registrosRoles.Show();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            rolComboBox.DataSource = RolesBLL.GetRoles();
            rolComboBox.DisplayMember = "Descripcion";
            rolComboBox.ValueMember = "RolId";
        }
    }
}
