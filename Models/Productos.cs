using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int IdTienda { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
