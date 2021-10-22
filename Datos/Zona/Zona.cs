using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Zona
{
    public class ZonaCRUD
    {
        domoticaEntities db = new domoticaEntities();

        public async Task<bool> Agregar(zona model)
        {
            try
            {
                db.zona.Add(model);
                await db.SaveChangesAsync();  
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<zona>> ObtenerZonas()
        {
            try
            {
                return await db.zona.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
