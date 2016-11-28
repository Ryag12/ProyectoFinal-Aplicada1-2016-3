using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.Entity;

namespace DAL
{
     public class ProyectoFinalDb : DbContext
    {
        public ProyectoFinalDb() : base("name = ConStr")
        {

        }
        public virtual DbSet<Vendedores> Vendedor { get; set; }

        public virtual DbSet <Usuarios> Usuario { get; set; }

        public virtual DbSet<Productos> Producto { get; set; }

        public virtual DbSet<TiposVehiculos> TiposVehiculos { get; set; }

        public virtual DbSet<Proveedores> Proveedores { get; set; }

    }
}
