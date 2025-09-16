using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
	[TestClass]
	public class ServiciosPrueba
	{
		private readonly IConexion? iConexion;
		private List<Servicios>? lista;
		private Servicios? entidad;




		public ServiciosPrueba()
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
			this.lista = this.iConexion!.Servicios!.ToList();
			return lista.Count > 0;
		}

		public bool Guardar()
		{
			// Crear un nuevo Componente de ejemplo
			this.entidad = new Servicios
			{
				Nombre = "Teclado",
				Descripcion = "Teclado mec�nico de prueba"
			};

			this.iConexion!.Servicios!.Add(this.entidad);
			this.iConexion!.SaveChanges();
			return true;
		}

		public bool Modificar()
		{
			this.entidad!.Descripcion = "Teclado mec�nico actualizado";
			var entry = this.iConexion!.Entry<Servicios>(this.entidad);
			entry.State = EntityState.Modified;
			this.iConexion!.SaveChanges();
			return true;
		}

		public bool Borrar()
		{
			this.iConexion!.Servicios!.Remove(this.entidad!);
			this.iConexion!.SaveChanges();
			return true;
		}
	}
}