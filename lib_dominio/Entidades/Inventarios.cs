using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Inventarios
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int Piezas_Disponibles { get; set; }
        public int Producto { get; set; }
        public Productos? Productos { get; set; }
    }
}
