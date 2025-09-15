using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Orden_Productos
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public int Orden { get; set; }
        public Productos? Productos { get; set; }
        public Orden_Servicios? Orden_Servicios { get; set; }
    }
}
