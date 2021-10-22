using Datos;
using Datos.Zona;
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
    public partial class AgregarZona : Form
    {
        public AgregarZona()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            zona zon = new zona { 
                nombre_zona =  this.txtNombre.Text,
                fecha_alta = DateTime.Now
            };

            ZonaCRUD crud = new ZonaCRUD(); 
            if(crud.Agregar(zon).Result)
            {
                MessageBox.Show("Guardado con Exito", string.Format("Se Guardo la zona {0}", zon.nombre_zona), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Text = String.Empty; this.txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Error al Guardar", "Hubo un error al guardar la zona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
