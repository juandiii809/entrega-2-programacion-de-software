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
        private readonly IConexion? iConexion;
        private List<Componentes>? lista;
        private Componente? entidad;


    

        public CRUD()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
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
            this.lista = this.iConexion!.Componentes!.ToList();
            return lista.Count > 0;
        }
        
        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Componente
            {
                Nombre = "Teclado",
                Descripcion = "Teclado mecánico de prueba"
            };

            this.iConexion!.Componentes!.Add(this.entidad);
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Descripcion = "Teclado mecánico actualizado";
            var entry = this.iConexion!.Entry<Componente>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Componentes!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}
