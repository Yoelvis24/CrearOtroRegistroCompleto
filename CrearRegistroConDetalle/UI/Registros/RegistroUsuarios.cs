using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrearRegistroConDetalle.DAL;
using CrearRegistroConDetalle.Entidades;
using CrearRegistroConDetalle.BLL;

namespace CrearRegistroConDetalle.UI.Registros
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            aliasTextBox.Clear();
            nombresTextBox.Clear();
            claveTextBox.Clear();
            confirmarTextBox.Clear();
            emailTextBox.Clear();
            IngresoDateTimePicker.Value = DateTime.Now;
            activoCheckBox.Checked = false;
        }



        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar 
        //y que la clave y su confirmacion sean iguales
        private bool Validar()
        {
            bool paso = true;

            if (nombresTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(nombresTextBox, "Campo obligatorio");
                paso = false;
            }

            if (claveTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(claveTextBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(confirmarTextBox, "Campo obligatorio");
                paso = false;
            }

            if (emailTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(emailTextBox, "Campo obligatorio");
                paso = false;
            }

            if (RolComboBox.Text == "")
            {
                UsuarioErrorProvider.SetError(RolComboBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                UsuarioErrorProvider.SetError(confirmarTextBox, "Claves no coinciden");
                paso = false;
            }

            return paso;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            usuarios.Nombres = nombresTextBox.Text;
            usuarios.Alias = aliasTextBox.Text;
            usuarios.Clave = claveTextBox.Text;
            usuarios.RolId = RolComboBox.SelectedIndex;
            usuarios.Email = emailTextBox.Text;
            usuarios.FechaIngreso = IngresoDateTimePicker.Value;
            usuarios.Activo = activoCheckBox.Checked;

            return usuarios;
        }

        private void LlenaCampos(Usuarios usuarios)
        {
            UsuarioIdNumericUpDown.Value = usuarios.UsuarioId;
            aliasTextBox.Text = usuarios.Alias;
            nombresTextBox.Text = usuarios.Nombres;
            RolComboBox.SelectedIndex = usuarios.RolId;
            emailTextBox.Text = usuarios.Email;
            IngresoDateTimePicker.Value = usuarios.FechaIngreso;
            activoCheckBox.Checked = usuarios.Activo;
        }

        private bool ExisteEnBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuarios != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            int id = (int)UsuarioIdNumericUpDown.Value;

            Limpiar();
            usuarios = UsuariosBLL.Buscar(id);
            if (usuarios != null)
            {
                LlenaCampos(usuarios);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            usuarios = LlenaClase();

            //Determinar si es guardar o modificar
            if (UsuarioIdNumericUpDown.Value == 0)
            {
                paso = UsuariosBLL.Guardar(usuarios, aliasTextBox.Text);
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuarios);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("El usuario ha sido guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            UsuarioErrorProvider.Clear();
            int id = (int)UsuarioIdNumericUpDown.Value;
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                UsuarioErrorProvider.SetError(UsuarioIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            RolComboBox.DataSource = RolesBLL.GetRoles();
            RolComboBox.DisplayMember = "Descripcion";
            RolComboBox.ValueMember = "RolId";
        }
    }
}
