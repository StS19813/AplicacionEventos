using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AolicacionEventos.Logica
{
    public class ClsDias
    {
        public int Dias(TimeSpan tsDiferencia)
        {
            int cadena = Math.Abs(tsDiferencia.Days);

            return cadena;
        }
    }
}
