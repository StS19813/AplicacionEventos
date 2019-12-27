using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AolicacionEventos.Logica
{
    public class ClsMinutos
    {
        /// <summary>
        /// obtiene la diferencia de tiempo de tiempo en minutos.
        /// </summary>
        /// <param name="tsDiferencia"> contiene la diferencia de la fecha del evento con la fecha actual en minutos.</param>
        /// <returns></returns>
        public int Minutos(TimeSpan tsDiferencia)
        {
            int cadena = Math.Abs(tsDiferencia.Minutes);

            return cadena;
        }
    }
}
