using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
//cambiar los nombres y las modificaciones por algo bueno 
{
    [TestClass]
    public class Orden_ProductosPrueba
    {
        private readonly IConexion? IConexion;
        private List<Orden_productos>? lista;
        private Orden_productos? entidad;




        public Orden_ProductosPrueba()
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
            this.lista = this.IConexion!.Orden_productos!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Productos
            {
                Cantidad = 10
            };

            this.IConexion!.Orden_productos!.Add(this.entidad);
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Cantida = 1000000;
            var entry = this.IConexion!.Entry<Orden_productos>(this.entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.IConexion!.Orden_productos!.Remove(this.entidad!);
            this.IConexion!.SaveChanges();
            return true;
        }
    }
}