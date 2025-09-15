using lib_dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public class IOrden_serviciosAplicacion
    {
        void Configurar(string StringConexion);
        List<Orden_Servicios> Listar();
        Orden_Servicios? Guardar(Orden_Servicios? entidad);
        Orden_Servicios? Modificar(Orden_Servicios? entidad);
        Orden_Servicios? Borrar(Orden_Servicios? entidad);
    }
}
