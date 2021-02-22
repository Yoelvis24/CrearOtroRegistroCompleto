using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrearOtroRegistroCompleto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void rUsuariosButton_Click(object sender, EventArgs e)
        {
            RegistroForm registrosUsuarios = new RegistroForm();
            registrosUsuarios.Show();
        }

        private void rRolesButton_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroRoles registrosRoles = new UI.Registros.RegistroRoles();
            registrosRoles.Show();
        }
    }
}
