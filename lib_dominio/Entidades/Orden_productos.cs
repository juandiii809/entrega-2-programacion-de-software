using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Orden_productos
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int producto { get; set; }
        public int orden { get; set; }
        [ForeignKey("producto")]public Productos? _producto { get; set; }
        [ForeignKey("orden")]public Orden_servicios? _Orden_servicios { get; set; }
    }
}
