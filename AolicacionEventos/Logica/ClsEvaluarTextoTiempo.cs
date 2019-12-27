using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AolicacionEventos.Logica
{
    public class ClsEvaluarTextoTiempo
    {
        public string DarFormato(double Diferencia)
        {
            string cTiempoTranscurrido=string.Empty;

            if(Diferencia >30*24*60)
            {
                cTiempoTranscurrido = (((Diferencia/60)/24)/30) + " Meses";
            }

            if (Diferencia< 30 * 24 * 60 && Diferencia>60*24)
            {
                cTiempoTranscurrido = (Diferencia/60/24) + " Días.";
            }

            if (Diferencia < 24 * 60 && Diferencia > 60)
            {
                cTiempoTranscurrido = (Diferencia / 60) + " Horas.";
            }

            if (Diferencia <  60 && Diferencia > 1)
            {
                cTiempoTranscurrido = (Diferencia) + " Minutos.";
            }


            return cTiempoTranscurrido;
        }
    }
}
