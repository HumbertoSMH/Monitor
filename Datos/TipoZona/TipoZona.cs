using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.TipoDispositivo
{
    public class TipoDispositivoCRUD
    {
        domoticaEntities db = new domoticaEntities();   

        public async Task<List<tipoDispositivo>> Obtener()
        {
            try
            {
                return await db.tipoDispositivo.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
