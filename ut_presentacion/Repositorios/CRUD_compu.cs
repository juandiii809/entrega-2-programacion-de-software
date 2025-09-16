using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class CRUD
    {
        private readonly IConexion? IConexion;
        private List<Computadores>? lista;
        private Computadores? entidad;




        public CRUD()
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
                Descripcion = "Teclado mecánico de prueba"
            };

            this.IConexion!.Computadores!.Add(this.entidad);
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Descripcion = "Teclado mecánico actualizado";
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