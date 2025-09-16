using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
//cambiar los nombres y las modificaciones por algo bueno 
{
    [TestClass]
    public class ProductosPrueba
    {
        private readonly IConexion? IConexion;
        private List<Productos>? lista;
        private Productos? entidad;




        public ProductosPrueba()
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
            this.lista = this.IConexion!.Productos!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Productos
            {
                Nombre = "Pructo1"
            };

            this.IConexion!.Productos!.Add(this.entidad);
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre = "no se ";
            var entry = this.IConexion!.Entry<Productos>(this.entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.IConexion!.Productos!.Remove(this.entidad!);
            this.IConexion!.SaveChanges();
            return true;
        }
    }
}