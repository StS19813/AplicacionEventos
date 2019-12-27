using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AolicacionEventos.Objetos;

namespace AolicacionEventos.Interfaces
{
    public interface IVisualizar
    {
        void visualizarEventos(List<ClsEventos> lstEventos);
    }
}
