using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AolicacionEventos.Logica
{
    public class ClsHoras
    {
        public int Horas(TimeSpan tsDiferencia)
        {
            int cadena = Math.Abs(tsDiferencia.Hours);

            return cadena;
        }
    }
}
