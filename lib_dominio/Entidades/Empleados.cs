using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Empleados
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Correo { get; set; }
        public int Puesto { get; set; }
        public Puestos? _Puesto { get; set; }

        //public List<Orden_servicios>? Orden_Servicios;
    }
}
