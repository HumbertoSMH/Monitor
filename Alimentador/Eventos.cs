using Datos;
using Datos.Bitacora;
using Datos.Dispositivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alimentador
{
    public class Eventos
    {
        List<string> eventosTermometro = new List<string>
        {
            "Dispositivo fuera de linea",
            "Dispositivo en linea",
            "Cambio de indicadores",
            "Aumento de temperatura",
            "Diminución de temperatura"
        };

        List<string> eventosIluminacion = new List<string> {
            "Dispositivo encendido",
            "Dispositivo apagado",
            "Encendido programado",
            "Cambio de color"
        };

        List<string> eventosHumedad = new List<string>
        {
            "Dispositivo fuera de linea",
            "Dispositivo en linea",
            "Cambio de indicadores",
            "Aumento de humedad",
            "Diminución de humedad"
        };

        List<string> eventosInfrarrojo = new List<string>
        {
            "Encendido de TV1",
            "Encendido de TV2",
            "Apagado de todos los dispositivos",
            "Temperatura del Aire acondicionado en 23° de acuerdo a cambio de temperatura",
            "Aire acondicionado apagado",
            "Aire acondicionado encendido"
        };

        public void RegistrarBitacora()
        {
            try
            {
                DispositivoCRUD tipoDispositivo = new DispositivoCRUD();
                List<dispositivo> list = tipoDispositivo.ObtenerTodos().Result;
                BitacoraCRUD crud = new BitacoraCRUD();
                foreach (var dispositivo in list)
                {
                    switch (dispositivo.id_tipo_dispositivo)
                    {
                        case 1:
                            Random rand = new Random(Environment.TickCount);
                            int mensaje = rand.Next(0, 4);
                            bitacora bitacora = new bitacora
                            {
                                descripcionEvento = eventosIluminacion.ElementAt(mensaje),
                                id_dispositivo = dispositivo.id_dispositivo,
                                fechaEvento = DateTime.Now
                            };
                            bool resp = crud.Agregar(bitacora).Result;
                            break;
                        case 2:
                            Random rand1 = new Random(Environment.TickCount);
                            int mensaje1 = rand1.Next(0, 4);
                            bitacora bitacora1 = new bitacora
                            {
                                descripcionEvento = eventosTermometro.ElementAt(mensaje1),
                                id_dispositivo = dispositivo.id_dispositivo,
                                fechaEvento = DateTime.Now
                            };
                            bool resp1 = crud.Agregar(bitacora1).Result;
                            break;
                        case 3:
                            Random rand2 = new Random(Environment.TickCount);
                            int mensaje2 = rand2.Next(0, 4);
                            bitacora bitacora2 = new bitacora
                            {
                                descripcionEvento = eventosIluminacion.ElementAt(mensaje2),
                                id_dispositivo = dispositivo.id_dispositivo,
                                fechaEvento = DateTime.Now
                            };
                            bool resp2 = crud.Agregar(bitacora2).Result;
                            break;
                        case 4:
                            Random rand3 = new Random(Environment.TickCount);
                            int mensaje3 = rand3.Next(0, 4);
                            bitacora bitacora3 = new bitacora
                            {
                                descripcionEvento = eventosHumedad.ElementAt(mensaje3),
                                id_dispositivo = dispositivo.id_dispositivo,
                                fechaEvento = DateTime.Now
                            };
                            bool resp3 = crud.Agregar(bitacora3).Result;
                            break;
                        case 5:
                            Random rand4 = new Random(Environment.TickCount);
                            int mensaje4 = rand4.Next(0, 5);
                            bitacora bitacora4 = new bitacora
                            {
                                descripcionEvento = eventosInfrarrojo.ElementAt(mensaje4),
                                id_dispositivo = dispositivo.id_dispositivo,
                                fechaEvento = DateTime.Now
                            };
                            bool resp4 = crud.Agregar(bitacora4).Result;
                            break;
                        default:
                            bool respuesta = false;
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
