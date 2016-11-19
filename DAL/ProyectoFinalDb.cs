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
        public DbSet<Vendedor> Vendedor { get; set; }

        public DbSet <Usuarios> Usuario { get; set; }

        public DbSet<Productos> Productos { get; set; }

    }
}
