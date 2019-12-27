using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AolicacionEventos.Interfaces;

namespace AolicacionEventos.Logica
{
    class ClsCompararEvento : ICompararEvento
    {
        /// <summary>
        /// compara la fecha del evento con la fecha actual y verifica si ya ha ocurrido el evento o aun va a ocurrir.
        /// </summary>
        /// <param name="dtFechaEvento">contiene la fecha del evento</param>
        /// <returns>contiene un numero entero en donde si el valor es negativo aun no ha ocurrido el evento y si es positivo ya ha ocurrido y si es 0 es el día del evento.</returns>
        public string Comparar(DateTime dtFechaEvento)
        {
            DateTime dtHoy = DateTime.Now;

            int result = DateTime.Compare(dtHoy, dtFechaEvento);

            ClsAsignacionTextoEvento oTextoEvento = new ClsAsignacionTextoEvento();

            return oTextoEvento.AsignarValorCadena(result); 
        }
    }
}
