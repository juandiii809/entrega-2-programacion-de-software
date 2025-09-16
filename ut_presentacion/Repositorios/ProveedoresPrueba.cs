using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
//cambiar los nombres y las modificaciones por algo bueno 
{
    [TestClass]
    public class ProveedoresPrueba
    {
        private readonly IConexion? IConexion;
        private List<Proveedores>? lista;
        private Proveedores? entidad;




        public ProveedoresPrueba()
        {
            IConexion = new Conexion();
            IConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.IConexion!.Proveedores!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Proveedores
            {
                Nombre = "Teclado",
            };

            this.IConexion!.Proveedores!.Add(this.entidad);
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre = "no se ";
            var entry = this.IConexion!.Entry<Proveedores>(this.entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.IConexion!.Proveedores!.Remove(this.entidad!);
            this.IConexion!.SaveChanges();
            return true;
        }
    }
}