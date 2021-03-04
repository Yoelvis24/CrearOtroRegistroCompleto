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
    public partial class RegistroRoles : Form
    {
        public List<RolesDetalle> Detalle { get; set; }
        public RegistroRoles()
        {
            InitializeComponent();

            this.Detalle = new List<RolesDetalle>();
        }

        private void CargarGrid()
        {
            RolDetalleDataGridView.DataSource = null;
            RolDetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            ActivoCheckBox.Checked = false;
            DescripcionTextBox.Clear();
            RolErrorProvider.Clear();
            AsignadoCheckBox.Checked = false;
            this.Detalle = new List<RolesDetalle>();
            CargarGrid();
        }


        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar
        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                RolErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if(RolesBLL.ExisteRol(DescripcionTextBox.Text))
            {
                RolErrorProvider.SetError(DescripcionTextBox, "rol existente");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if(this.Detalle.Count == 0)
            {
                RolErrorProvider.SetError(RolDetalleDataGridView, "Favor de agregar un permiso");
                PermisoIdComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private Roles LlenaClase()
        {
            Roles roles = new Roles();
            roles.RolId = (int)RolIdNumericUpDown.Value;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.EsActivo = ActivoCheckBox.Checked;

            roles.RolesDetalle = this.Detalle;
            return roles;
        }

        private void LLenaCampos(Roles roles)
        {
            RolIdNumericUpDown.Value = roles.RolId;
            ActivoCheckBox.Checked = roles.EsActivo;
            DescripcionTextBox.Text = roles.Descripcion;

            this.Detalle = roles.RolesDetalle;
            CargarGrid();
        }


        private bool ExisteEnBaseDeDatos()
        {
            var roles = new Roles();
            roles = RolesBLL.Buscar((int)RolIdNumericUpDown.Value);
            return (roles != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            int id = (int)RolIdNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
            {
                LLenaCampos(roles);
            }
            else
            {
                MessageBox.Show("Rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;
            
            if (!Validar())
                return;

            roles = LlenaClase();
            var paso = RolesBLL.Guardar(roles);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("El rol ha sido guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)RolIdNumericUpDown.Value;
            RolErrorProvider.Clear();

            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("El rol ha sido eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                RolErrorProvider.SetError(RolIdNumericUpDown, "Este Id no existe");
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RolDetalleDataGridView.DataSource != null)
                this.Detalle = (List<RolesDetalle>)RolDetalleDataGridView.DataSource;

            //Agregar un nuevo detalle con los datos introducidos
            this.Detalle.Add(
                new RolesDetalle(
                rolDetalleId: 0,
                rolId: (int)RolIdNumericUpDown.Value,
                permisoId: Convert.ToInt32(PermisoIdComboBox.Text),
                esAsignado: AsignadoCheckBox.Checked
                )
            );
            CargarGrid();
            PermisoIdComboBox.Focus();
            AsignadoCheckBox.Checked = false;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if((RolDetalleDataGridView.Rows.Count > 0) && RolDetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(RolDetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void RegistroRoles_Load(object sender, EventArgs e)
        {
            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "PermisoId";
            PermisoIdComboBox.ValueMember = "Descripcion";
        }
    }
}
