using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int producto { get; set; }
        [ForeignKey("producto")]public Productos? _producto { get; set; }
    }
}
