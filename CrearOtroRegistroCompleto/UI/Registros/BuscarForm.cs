using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrearOtroRegistroCompleto
{
    public partial class BuscarForm : Form
    {
        public BuscarForm()
        {
            InitializeComponent();
            //cambiar formato de la fecha
            FechaIngresoResultdateTime.Format = DateTimePickerFormat.Custom;
            FechaIngresoResultdateTime.CustomFormat = "dd/MM/yyyy";
        }

        private void FechaIngresoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
