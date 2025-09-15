using lib_dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public class IOrden_productosAplicacion
    {
        void Configurar(string StringConexion);
        List<Orden_Productos> Listar();
        Orden_Productos? Guardar(Orden_Productos? entidad);
        Orden_Productos? Modificar(Orden_Productos? entidad);
        Orden_Productos? Borrar(Orden_Productos? entidad);
    }
}
