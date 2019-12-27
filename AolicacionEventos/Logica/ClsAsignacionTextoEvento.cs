using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AolicacionEventos.Objetos;

namespace AolicacionEventos.Logica
{
    public class ClsAsignacionTextoEvento
    {
     
        /// <summary>
        /// determina si el evento ya ha ocurrido o va a ocurrir en cadena de texto
        /// </summary>
        /// <param name="iResult">contiene el resultado de la comparación de fechas.</param>
        /// <returns>retorna la cadena de texto según el resultado.</returns>
        public string AsignarValorCadena (int iResult)
        {
            string cCadena =string.Empty;

            if (iResult < 0)
                cCadena = "ocurrirá dentro de: ";
            else if (iResult == 0)
                cCadena = "es hoy";
            else
                cCadena = "Ocurrió hace:      ";

            return cCadena;

        }
    }
}
