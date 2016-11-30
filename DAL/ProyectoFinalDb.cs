using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProyectoFinalDb : DbContext
    {
        public ProyectoFinalDb() : base("name=ConStr")
        {
                
        }

        public virtual DbSet<Vendedores> Vendedor { get; set; }

        public virtual DbSet<Usuarios> Usuario { get; set; }

        public virtual DbSet<Productos> Producto { get; set; }

        public virtual DbSet<TiposVehiculos> TiposVehiculos { get; set; }

        public virtual DbSet<Proveedores> Proveedore { get; set; }

        public virtual DbSet<Facturas> Factura { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facturas>()
                .HasMany<Productos>(f => f.Productos)
                .WithMany(p=> p.Facturas)
                .Map(Vp=>
                {
                    Vp.MapLeftKey("FacturaId");
                    Vp.MapRightKey("IdProducto");
                    Vp.ToTable("FacturasProductos");
                });
        }
    }
}
