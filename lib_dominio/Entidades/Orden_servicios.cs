using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Orden_Servicios
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public int Servicio { get; set; }
        public int Cliente { get; set; }
        public int Empleado { get; set; }
        public Servicios? Servicios { get; set; }
        public Clientes? Clientes { get; set; }
        public Empleados? Empleados { get; set; }

        public List<Orden_Productos>? Productos;

        public List<Facturas>? Facturas;
    }
}
