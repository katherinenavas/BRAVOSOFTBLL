using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bravosoftbll
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void Contrato_Click(object sender, EventArgs e)
        {

        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDeDatodp.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.baseDeDatodp.empleado);

        }
    }
}
