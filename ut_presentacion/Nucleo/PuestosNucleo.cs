using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class PuestosNucleo
    {
        public static Puestos? Puestos()
        {
            var entidad = new Puestos();
            entidad.Nombre = "cajero";
            entidad.Descripcion = "se encarga de cobrar y facturar los productos";
            entidad.Salario = 1200000.0m;
            return entidad;
        }
    }
}
