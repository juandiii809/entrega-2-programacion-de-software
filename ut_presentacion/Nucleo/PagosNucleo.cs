using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class PagosNucleo
    {
        public static Pagos? Pagos()
        {
            var entidad = new Pagos();
            entidad.Fecha = DateTime.Now;
            entidad.Monto = 1200000.0m;
            entidad.Tipo_Pago = "tarjeta";
            return entidad;
        }
    }
}
