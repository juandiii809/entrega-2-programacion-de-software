using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Orden_servicios
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public int Servicio { get; set; }
        public int Cliente { get; set; }
        public int Empleado { get; set; }
        public Servicios? _Servicio { get; set; }
        public Clientes? _Cliente { get; set; }
        public Empleados? _Empleado { get; set; }

        //public List<Orden_productos>? Productos;

        //public List<Facturas>? Facturas;
    }
}
