using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    
    public class TiposVehiculos
    {
        [Key]
        public int TiposVehiculosId { get; set; }

        public string Nombres { get; set; }

        public TiposVehiculos(string n)
        {
            this.Nombres = n;
        }
        public TiposVehiculos()
        {

        }
    }
}
