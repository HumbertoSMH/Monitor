using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Dispositivo;

namespace Monitor.Pantallas.Dispositivo
{
    public partial class AgregarDispositivo : Form
    {
        public AgregarDispositivo()
        {
            InitializeComponent();
        }

        private void AgregarDispositivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'domoticaDataSet.tipoDispositivo' Puede moverla o quitarla según sea necesario.
            this.tipoDispositivoTableAdapter.Fill(this.domoticaDataSet.tipoDispositivo);

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DispositivoCRUD crud = new DispositivoCRUD();
            dispositivo disp = new dispositivo {
                fecha_alta = DateTime.Now, 
                id_tipo_dispositivo = int.Parse(this.cmbTipo.SelectedValue.ToString()),
                nombre_dispotivo= this.txtNombre.Text
            };
            if(crud.Agregar(disp).Result)
            {
                MessageBox.Show("Guardado con Exito", string.Format("Se Guardado el dispotivo {0}", disp.nombre_dispotivo), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Text = String.Empty; this.txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Error al Guardar", "Hubo un error al guardar el dispotivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
