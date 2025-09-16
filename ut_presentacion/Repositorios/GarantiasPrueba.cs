using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
    //cambiar las fechas "absolutamente todas las fechas"
{
    [TestClass]
    public class GarantiasPrueba
    {
        private readonly IConexion? iConexion;
        private List<Garantias>? lista;
        private Garantias? entidad;




        public GarantiasPrueba()
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
            this.lista = this.iConexion!.Garantias!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Garantias
            {
                Fecha_inicio = DateTime.Now
            };

            this.iConexion!.Garantias!.Add(this.entidad);
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Fecha_fin= DateTime.Now;
            var entry = this.iConexion!.Entry<Garantias>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Garantias!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}