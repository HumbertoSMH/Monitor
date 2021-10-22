using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Dispositivo.AgregarDispositivo frmAgregar = new Pantallas.Dispositivo.AgregarDispositivo();
            frmAgregar.ShowDialog();
        }

        private void agregarDispotivoAZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Zona.AgregarDispotivoAZona frmAgregar = new Pantallas.Zona.AgregarDispotivoAZona();
            frmAgregar.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pantallas.Zona.AgregarZona frmAgregar = new Pantallas.Zona.AgregarZona();
            frmAgregar.ShowDialog();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Bitacora.Bitacora frmBitacora = new Pantallas.Bitacora.Bitacora();
            frmBitacora.ShowDialog();
        }
    }
}
