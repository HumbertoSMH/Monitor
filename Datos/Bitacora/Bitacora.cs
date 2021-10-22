using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Bitacora
{
    public class BitacoraCRUD
    {
        domoticaEntities db = new domoticaEntities();

        public async Task<bool> Agregar(bitacora model)
        {
            try
            {
                db.bitacora.Add(model);
                db.SaveChanges();  
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<bitacora>> ObtenerTodo()
        {
            try
            {
              return await db.bitacora.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<bitacora>> ObtenerPorDispositivo(int dispositivo)
        {
            try
            {
                return await db.bitacora.Where(m => m.id_dispositivo == dispositivo).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<bitacora>> ObtenerPorZona(int zona) 
        {
            try
            {
                var list = await ( from b in db.bitacora 
                            join d in db.dispositivo on b.id_dispositivo equals d.id_dispositivo
                            join z in db.zonaDispositivo on b.id_dispositivo equals z.id_dispositivo
                            where z.id_zona == zona 
                            select b).ToListAsync();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
