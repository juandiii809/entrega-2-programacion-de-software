using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades

namespace ut_presentacion.Nucleo
{
    public class ServiciosNucleo
    {
        public static Servicios? Servicios()
        {
            var entidad = new Servicios();
            entidad.Nombre = "mantenimiento";
            entidad.Descripcion = "da mantenimiento a los aparatos electronicos";
            entidad.Precio = 120000.0m;
            return entidad;
        }
    }
}
