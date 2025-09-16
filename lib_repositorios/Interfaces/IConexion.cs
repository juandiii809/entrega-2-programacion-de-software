﻿using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Componentes>? Componentes { get; set; }
        
        DbSet<Garantias>? Garantias { get; set; }
        DbSet<Marcas>? Marcas { get; set; }
        DbSet<Pagos>? Pagos { get; set; }
        DbSet<Puestos>? Puestos { get; set; }
        DbSet<Servicios>? Servicios { get; set; }
        DbSet<Clientes>? Clientes { get; set; }
        DbSet<Empleados>? Empleados { get; set; }
        DbSet<Computadores>? Computadores { get; set; }
        DbSet<Inventarios>? Inventarios { get; set; }
       
        DbSet<Orden_productos>? Orden_productos { get; set; }
        DbSet<Orden_servicios>? Orden_servicios { get; set; }
        DbSet<Productos>? Productos { get; set; }
        DbSet<Proveedores>? Proveedores { get; set; }
        DbSet<Facturas>? Facturas { get; set; }
        

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}