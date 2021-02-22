using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrearOtroRegistroCompleto.DAL;
using CrearOtroRegistroCompleto.Entidades;
using CrearOtroRegistroCompleto.BLL;

namespace CrearOtroRegistroCompleto.UI.Registros
{
    public partial class RegistroRoles : Form
    {
        public RegistroRoles()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            rolIdNumericUpDown.Value = 0;
            descripcionTextBox.Text = string.Empty;
            fechaCreacionDateTimePicker.Value = DateTime.Now;
        }

        private void LlenarCampos(Roles roles)
        {
            rolIdNumericUpDown.Value = roles.RolId;
            descripcionTextBox.Text = roles.Descripcion;
        }
           

        private Roles LlenarClase()
        {
            Roles roles = new Roles();
            roles.RolId = Convert.ToInt32(rolIdNumericUpDown.Value);
            roles.Descripcion = descripcionTextBox.Text;
            roles.FechaCreacion = fechaCreacionDateTimePicker.Value;

            return roles;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Roles rol = RolesBLL.Buscar(Convert.ToInt32((int)rolIdNumericUpDown.Value));
            return (rol != null);
        }

        private bool Validar()
        {
            bool paso = true;
            if (rolIdNumericUpDown.Value == 0)
            {
                rolErrorProvider.SetError(rolIdNumericUpDown, "Campo obligatorio");
                paso = false;
            }

            if (descripcionTextBox.Text == "")
            {
                rolErrorProvider.SetError(descripcionTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;
            bool paso = false;

            if (!Validar())
                return;
            roles = LlenarClase();

            //Determinar si es guardar o modificar
            if (rolIdNumericUpDown.Value != 0)
                paso = RolesBLL.Guardar(roles);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe");
                    return;
                }
                paso = RolesBLL.Modificar(roles);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se ha guardado correctamente");
            }
            else
                MessageBox.Show("No fue posible guardar");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Roles roles = new Roles();
            int.TryParse(rolIdNumericUpDown.Text, out id);

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
            {
                MessageBox.Show("Usuario encontrado");
                LlenarCampos(roles);
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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            rolErrorProvider.Clear();
            int id;
            int.TryParse(rolIdNumericUpDown.Text, out id);

            Limpiar();

            if (RolesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                rolErrorProvider.SetError(rolIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }
    }
}
