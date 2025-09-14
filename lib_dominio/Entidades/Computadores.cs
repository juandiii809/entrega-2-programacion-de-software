using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Computadores
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Modelo { get; set; }
        public decimal Precio { get; set; }

        public int marca { get; set; }
        public int componente { get; set; }
    }
}
