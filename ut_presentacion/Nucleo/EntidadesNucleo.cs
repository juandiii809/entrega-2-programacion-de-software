using lib_dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Clientes? Clientes() 
        {
            var entidad = new Clientes();
            entidad.Nombre = "pruebas";
            entidad.Apellido = "prueba";
            entidad.Cedula = "pruebas";
            entidad.Correo = "pruebas";
            entidad.Computador = 1;
            return entidad;
        }

        public static Componentes? Componentes() 
        {
            var entidad = new Componentes();
            entidad.Nombre = "pruebas";
            entidad.Descripcion = "pruebas";
            return entidad;
        }

        public static Computadores? Computadores() 
        {
            var entidad = new Computadores();
            entidad.Nombre = "pruebas";
            entidad.Modelo = "pruebas";
            entidad.Precio = 1000000m;
            entidad.Marca = 1;
            entidad.Componente = 1;
            return entidad;
        }

        public static Empleados? Empleados() 
        {
            var entidad = new Empleados();
            entidad.Nombre = "pruebas";
            entidad.Apellido = "prueba";
            entidad.Cedula = "pruebas";
            entidad.Correo = "pruebas";
            entidad.Puesto = 1;
            return entidad;
        }

        public static Facturas? Facturas() 
        {
            var entidad = new Facturas();
            entidad.Fecha = DateTime.Now;
            entidad.Descripcion = "pruebas";
            entidad.Valor_total = 1000000m;
            entidad.pago = 1;
            entidad.garantia = 1;
            entidad.orden = 1;
            return entidad;
        }

        public static Garantias? Garantias() 
        {
            var entidad = new Garantias();
            entidad.Fecha_inicio = DateTime.Now;
            entidad.Fecha_fin = DateTime.Now;
            return entidad; 
        }

        public static Inventarios? Inventarios() 
        {
            var entidad = new Inventarios();
            entidad.Descripcion = "pruebas";
            entidad.Piezas_Disponibles = 50;
            entidad.producto = 1;
            return entidad;
        }

        public static Marcas? Marcas() 
        {
            var entidad = new Marcas();
            entidad.Nombre = "pruebas";
            entidad.Descripcion = "pruebas";
            return entidad;
        }

        public static Orden_productos? Orden_productos() 
        {
            var entidad = new Orden_productos();
            entidad.Cantidad = 3;
            entidad.producto = 1;
            entidad.orden = 1;
            return entidad;
        }

        public static Orden_servicios? Orden_servicios() 
        {
            var entidad = new Orden_servicios();
            entidad.Estado = true;
            entidad.Fecha = DateTime.Now;
            entidad.Precio = 1000000m;
            entidad.servicio = 1;
            entidad.cliente = 1;
            entidad.empleado = 1;
            return entidad;
        }

        public static Pagos? Pagos() 
        {
            var entidad = new Pagos();
            entidad.Fecha = DateTime.Now;
            entidad.Monto = 1000000m;
            entidad.Tipo_Pago = "pruebas";
            return entidad;
        }

        public static Productos? Productos() 
        {
            var entidad = new Productos();
            entidad.Nombre = "pruebas";
            entidad.Descripcion = "pruebas";
            entidad.garantia = 1;
            return entidad; 
        }

        public static Proveedores? Proveedores() 
        {
            var entidad = new Proveedores();
            entidad.Nombre = "pruebas";
            entidad.Correo = "prueba";
            entidad.Telefono = "pruebas";
            entidad.producto = 1;
            return entidad;
        }

        public static Puestos? Puestos() 
        {
            var entidad = new Puestos();
            entidad.Nombre = "pruebas";
            entidad.Descripcion = "pruebas";
            entidad.Salario = 50000;
            return entidad;
        }

        public static Servicios? Servicios() 
        {
            var entidad = new Servicios();
            entidad.Nombre = "pruebas";
            entidad.Descripcion = "pruebas";
            entidad.Precio = 50000;
            return entidad; 
        }
    }
}
