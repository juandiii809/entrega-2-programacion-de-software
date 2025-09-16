using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class GarantiasNucleo
    {
        public static Garantias? Garantias()
        {
            var entidad = new Garantias();
            entidad.Fecha_inicio = DateTime.Now;
            entidad.Fecha_fin = DateTime.Now;
            return entidad;
        }
    }
}
