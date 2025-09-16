using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class MarcasNucleo
    {
        public static Marcas? Marcas()
        {
            var entidad = new Marcas();
            entidad.Nombre = "lenovo";
            entidad.Descripcion = "marca china de buena calidad";
            return entidad;
        }
    }
}
