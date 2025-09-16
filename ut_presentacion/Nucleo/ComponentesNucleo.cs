using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;


namespace ut_presentacion.Nucleo
{
    public class ComponentesNucleo
    {
        public static Componentes? Componentes()
        {
            var entidad = new Componentes();
            entidad.Nombre = "ram";
            entidad.Descripcion = "random access memory";
            return entidad; 
        }
    }
}
