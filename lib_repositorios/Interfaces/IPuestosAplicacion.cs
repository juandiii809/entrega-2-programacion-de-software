using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public class IPuestosAplicacion
    {
        void Configurar(string StringConexion);
        List<Notas> PorEstudiante(Notas? entidad);
        List<Notas> Listar();
        Notas? Guardar(Notas? entidad);
        Notas? Modificar(Notas? entidad);
        Notas? Borrar(Notas? entidad);
    }
}
