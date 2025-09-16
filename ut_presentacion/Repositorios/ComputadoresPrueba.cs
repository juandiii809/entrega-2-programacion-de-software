using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
    //cambiar los nombres y las modificaciones por algo bueno 
{
    [TestClass]
    public class ComputadoresPrueba
    {
        private readonly IConexion? IConexion;
        private List<Computadores>? lista;
        private Computadores? entidad;




        public ComputadoresPrueba()
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
            this.lista = this.IConexion!.Computadores!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Computadores
            {
                Nombre = "Teclado",
            };

            this.IConexion!.Computadores!.Add(this.entidad);
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre="no se ";
            var entry = this.IConexion!.Entry<Computadores>(this.entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.IConexion!.Computadores!.Remove(this.entidad!);
            this.IConexion!.SaveChanges();
            return true;
        }
    }
}