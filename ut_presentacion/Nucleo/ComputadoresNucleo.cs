using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class ComputadoresNucleo
    {
        public static Computadores? computadores()
        {
            var entidad = new Computadores();
            entidad.Nombre = "ttp123";
            entidad.Modelo = "ndeid";
            entidad.Precio = 2000000.0m;
            entidad.Marca = 1;
            entidad.Componente = 1;
            return entidad;
        }
    }
}
