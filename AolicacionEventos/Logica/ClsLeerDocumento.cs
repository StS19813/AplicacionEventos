using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AolicacionEventos.Interfaces;
using AolicacionEventos.Objetos;

namespace AolicacionEventos.Logica
{
    public class ClsLeerDocumento : ILector
    {
        /// <summary>
        /// lee un documento de texto
        /// </summary>
        /// <param name="cRuta">contienen la ruta del archivo que se va a leer.</param>
        /// <returns>retorna una lista que contiene el nombre de los eventos y su fecha.</returns>
        public List<ClsEventos> Lector(string cRuta)
        {
            List<ClsEventos> oEventos;

            string[] lines = File.ReadAllLines(cRuta);

            ClsObtencionFecha oObtencionFecha = new ClsObtencionFecha();

            oEventos= oObtencionFecha.ObtenerFecha(lines);

            return oEventos;
        }
    }
}
