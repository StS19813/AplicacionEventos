using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AolicacionEventos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lista de todos los eventos: ");
            DateTime dtHoy = DateTime.Now; //se obtiene la fecha de hoy
            TimeSpan DiasDiferencia; //guardara la fecha actual
            string cadena; //almacenera la cadena que se imprimirá en consola según la fecha

            Console.WriteLine("Fecha de hoy: \t" + dtHoy+"\n"); //imprime la fecha de hoy
      
            string[] lines = File.ReadAllLines("eventos.txt"); //obtiene todas las lineas del txt
            foreach (string linea in lines) //recorre todas las lineas
            {
                string[] separadas; //almacena las cadenas separadas
                separadas = linea.Split(','); //separa el nombre de los eventos de las fechas
                Console.WriteLine(separadas[0] + "\t \t"+separadas[1]);  //imprime las fechas
            }

            Console.WriteLine("\n \n");

            foreach (string linea in lines) //recorre todo el txt
            {
                string[] separadas;
                separadas = linea.Split(',');
                DateTime dtAux = Convert.ToDateTime(separadas[1]); //convierte las fechas a date time
                int result = DateTime.Compare(dtHoy, dtAux); //compara las fechas
                DiasDiferencia = dtHoy - dtAux; //obtiene la diferencia de las fechas

                if (result < 0) //formatea según el resultado
                    cadena = "ocurrirá dentro de: ";
                else if (result == 0)
                    cadena = "es hoy";
                else
                    cadena = "Ocurrió hace:      ";


                Console.WriteLine(separadas[0] + "\t" + cadena +"\t"+ Math.Abs(DiasDiferencia.Days)+" Dia(s)");//imprime el resultado en consola.
            }
            Console.ReadKey();
        }
    }
}
