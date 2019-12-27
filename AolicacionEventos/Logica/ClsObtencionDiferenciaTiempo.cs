using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AolicacionEventos.Logica;


namespace AolicacionEventos.Logica
{
    public class ClsObtencionDiferenciaTiempo 
    {
        TimeSpan tsDiasDiferencia; //guardara la diferencia del tiempo del evento a la fecha actual
        /// <summary>
        /// obtiene la diferencia de tiempo que existe entre la fecha del evento y la fecha de hoy.
        /// </summary>
        /// <param name="dtFechaEvento">contiene la fecha del evento.</param>
        /// <returns></returns>
        public string  CalcularDiferencia(DateTime dtFechaEvento)
        {
            tsDiasDiferencia = DateTime.Now - dtFechaEvento;
            ClsMinutos clsDias = new ClsMinutos();

            double Tiempo= clsDias.Minutos(tsDiasDiferencia);

            ClsEvaluarTextoTiempo oTextoTiempo = new ClsEvaluarTextoTiempo();
            

            return oTextoTiempo.DarFormato(Tiempo);
        }

    }
}
