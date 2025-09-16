using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int servicio { get; set; }
        public int cliente { get; set; }
        public int empleado { get; set; }
        [ForeignKey("servicio")]public Servicios? _Servicio { get; set; }
        [ForeignKey("cliente")]public Clientes? _cliente { get; set; }
        [ForeignKey("empleado")]public Empleados? _empleado { get; set; }

        //public List<Orden_productos>? Productos;

        //public List<Facturas>? Facturas;
    }
}
