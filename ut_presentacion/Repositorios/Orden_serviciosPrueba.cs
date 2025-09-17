using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class Orden_serviciosPrueba
    {
        private readonly IConexion? iConexion;
        private List<Orden_servicios>? lista;
        private Orden_servicios? entidad;




        public Orden_serviciosPrueba()
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
        
            this.lista = this.iConexion!.Orden_servicios!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            // Crear un nuevo Componente de ejemplo
            this.entidad = new Orden_servicios
            {
                Precio = 150.7m
                
             
            };

            this.iConexion!.Orden_servicios!.Add(this.entidad);
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            
            this.entidad!.Fecha = DateTime.Today;
           
            var entry = this.iConexion!.Entry<Orden_servicios>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Orden_servicios!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}