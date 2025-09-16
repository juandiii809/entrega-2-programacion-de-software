﻿using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Garantias>? Garantias { get; set; }
        public DbSet<Componentes>? Componentes { get; set; }
        public DbSet<Marcas>? Marcas { get; set; }
        public DbSet<Computadores>? Computadores { get; set; }
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Puestos>? Puestos { get; set; }
        public DbSet<Empleados>? Empleados { get; set; }
        public DbSet<Servicios>? Servicios { get; set; }
        public DbSet<Orden_servicios>? Orden_servicios { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Pagos>? Pagos { get; set; }
        public DbSet<Facturas>? Facturas { get; set; }
        public DbSet<Inventarios>? Inventarios { get; set; }
        public DbSet<Orden_productos>? Orden_productos { get; set; }
        public DbSet<Proveedores>? Proveedores { get; set; }
    }
}
