using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Facturas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public decimal Valor_total { get; set; }
        public int Pago { get; set; }
        public int Garantia { get; set; }
        public int Orden { get; set; }
        public Pagos? _Pago { get; set; }
        public Garantias? _Garantia { get; set; }
        //public Orden_servicios? Orden_Servicios { get; set; }
    }
}
