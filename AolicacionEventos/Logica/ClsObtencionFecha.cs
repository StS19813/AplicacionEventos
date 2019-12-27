using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AolicacionEventos.Objetos;

namespace AolicacionEventos.Logica
{
    public class ClsObtencionFecha
    {
        /// <summary>
        /// recibe todas las lineas del txt previamente leído y devuelve la lista de eventos 
        /// </summary>
        /// <param name="lineas">contiene los eventos con sus fechas en formato string</param>
        /// <returns></returns>
       public List<ClsEventos> ObtenerFecha(string[] lineas)
        {
            
            List<ClsEventos> lstEventos = new List<ClsEventos>();

            foreach (string linea in lineas) //recorre todas las lineas
            {
                ClsEventos oEventos = new ClsEventos();
                string[] separadas; //almacena las cadenas separadas
                separadas = linea.Split(','); //separa el nombre de los eventos de las fechas

                oEventos.cNombreEvento = separadas[0];
                oEventos.dtFechaEvento = Convert.ToDateTime(separadas[1]);

                lstEventos.Add(oEventos);
            }
            return lstEventos;
        } 
    }
}
