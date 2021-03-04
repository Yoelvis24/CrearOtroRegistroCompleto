using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrearRegistroConDetalle.UI.Registros;

namespace CrearRegistroConDetalle
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
            this.UsuarioToolStripMenuItem.Click += new EventHandler(this.UsuarioToolStripMenuItemClicked);
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItemClicked);

        }

        private void RolesToolStripMenuItemClicked(object sender, EventArgs e)
        {
            /*var rRoles = new RegistroRoles();
            rRoles.MdiParent = this;
            rRoles.Show();*/
            var registrarRoles = new RegistroRoles();
            registrarRoles.Show();
        }

        private void UsuarioToolStripMenuItemClicked(object sender, EventArgs e)
        {
            /*var rUsuarios = new RegistroRoles();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();*/
            var registrarUsuarios = new RegistroUsuarios();
            registrarUsuarios.Show();
        }
    }
}
