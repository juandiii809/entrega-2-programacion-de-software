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
        public int Marca { get; set; }
        public int Componente { get; set; }
        public Marcas? _Marca { get; set; }
        public Componentes? _Componente { get; set; }
        //public List<Clientes>? Clientes { get; set; }
    }
}
