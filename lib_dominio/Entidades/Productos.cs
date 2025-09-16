using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Productos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int garantia { get; set; }
        [ForeignKey("garantia")]public Garantias? _garantia { get; set; }

        //public List<Inventarios>? Inventarios;

        //public List<Orden_productos>? Orden_Productos;

        //public List<Proveedores>? Proveedores;
    }
}
