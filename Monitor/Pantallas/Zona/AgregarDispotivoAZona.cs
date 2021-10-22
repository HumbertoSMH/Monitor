using Datos;
using Datos.Dispositivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor.Pantallas.Zona
{
    public partial class AgregarDispotivoAZona : Form
    {
        public AgregarDispotivoAZona()
        {
            InitializeComponent();
        }

        private void AgregarDispotivoAZona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'domoticaDataSet3.zona' Puede moverla o quitarla según sea necesario.
            this.zonaTableAdapter.Fill(this.domoticaDataSet3.zona);
            // TODO: esta línea de código carga datos en la tabla 'domoticaDataSet2.dispositivo' Puede moverla o quitarla según sea necesario.
            this.dispositivoTableAdapter.Fill(this.domoticaDataSet2.dispositivo);
            // TODO: esta línea de código carga datos en la tabla 'domoticaDataSet.tipoDispositivo' Puede moverla o quitarla según sea necesario.
            this.tipoDispositivoTableAdapter.Fill(this.domoticaDataSet.tipoDispositivo);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            zonaDispositivo zd = new zonaDispositivo
            {
                id_dispositivo = int.Parse(cmbDispositivo.SelectedValue.ToString()),
                id_zona = int.Parse(cmbZona.SelectedValue.ToString())
            };
            DispositivoCRUD crud = new DispositivoCRUD();
            if (crud.AgregarAZona(zd).Result)
            {
                MessageBox.Show("Guardado con Exito",
                    string.Format("Se Guardo el dispotivo {0} en la zona {1}",
                                                          cmbDispositivo.SelectedText,
                                                          cmbZona.SelectedText),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Guardar", "Hubo un error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
