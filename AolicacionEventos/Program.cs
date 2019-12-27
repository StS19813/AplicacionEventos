using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AolicacionEventos.Logica;
using AolicacionEventos.Objetos;

namespace AolicacionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de todos los eventos: ");
            DateTime dtHoy = DateTime.Now; //se obtiene la fecha de hoy
            Console.WriteLine("Fecha de hoy: \t" + dtHoy+"\n"); //imprime la fecha de hoy

            ClsLeerDocumento oLeerDocumento = new ClsLeerDocumento();
            List<ClsEventos> lstEventos = oLeerDocumento.Lector("eventos.txt");//se obtiene una lista de los eventos
            ClsCompararEvento oTextoEvento = new ClsCompararEvento();
            ClsObtencionDiferenciaTiempo oDiferencia = new ClsObtencionDiferenciaTiempo();

            Console.BackgroundColor = ConsoleColor.Yellow;
            ClsTexto oTexto = new ClsTexto();
            foreach (var i in lstEventos)
            {
                oTexto.cNombreEvento = i.cNombreEvento;
                oTexto.cTiempoEvento= oTextoEvento.Comparar(i.dtFechaEvento);
                oTexto.cTiempoRestanteEvento = oDiferencia.CalcularDiferencia(i.dtFechaEvento);

                Console.WriteLine("  "+oTexto.cNombreEvento +"\t"+ oTexto.cTiempoEvento+ "\t"+oTexto.cTiempoRestanteEvento);
            }


            Console.ReadKey();
        }
    }
}
