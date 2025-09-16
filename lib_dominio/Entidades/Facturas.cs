using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int pago { get; set; }
        public int garantia { get; set; }
        public int orden { get; set; }
        [ForeignKey("pago")]public Pagos? _pago { get; set; }
        [ForeignKey("garantia")] public Garantias? _garantia { get; set; }
        [ForeignKey("orden")]public Orden_servicios? Orden_Servicios { get; set; }
    }
}
