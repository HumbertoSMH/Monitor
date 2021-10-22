using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Dispositivo
{
    public class DispositivoCRUD
    {
        domoticaEntities db = new domoticaEntities();
        public async Task<bool> Agregar(dispositivo model)
        {
            try
            {
                db.dispositivo.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        } 

        public async Task<List<dispositivo>> ObtenerTodos()
        {
            try
            {
              return db.dispositivo.ToList<dispositivo>();
            }
            catch (Exception)
            {
                return new List<dispositivo> { };
            }
        }

        public async Task<List<dispositivo>> ObtenerPorZona(int zona)
        {
            try
            {
                var disp = from d in db.dispositivo
                           join z in db.zonaDispositivo on d.id_dispositivo equals z.id_dispositivo
                           select d; 
                return disp.ToList<dispositivo>(); 

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
