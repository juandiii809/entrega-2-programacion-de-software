using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
//cambiar los nombres y las modificaciones por algo bueno 
{
    [TestClass]
    public class PagosPrueba
    {
        private readonly IConexion? IConexion;
        private List<Pagos>? lista;
        private Pagos? entidad;




        public PagosPrueba()
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
            this.lista = this.IConexion!.Pagos!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Pagos
            {
                Fecha = "2025/02/12"
            };

            this.IConexion!.Pagos!.Add(this.entidad);
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Fecha = "2025/10/12";
            var entry = this.IConexion!.Entry<Pagos>(this.entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.IConexion!.Pagos!.Remove(this.entidad!);
            this.IConexion!.SaveChanges();
            return true;
        }
    }
}