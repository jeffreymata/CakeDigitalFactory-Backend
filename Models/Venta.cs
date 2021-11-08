using System;
using System.Collections.Generic;

#nullable disable

namespace CakeDigitalFactory.Services.Models
{
    public partial class Venta
    {
        public int Id { get; set; }
        public int? IdEncargo { get; set; }
        public int? NumCai { get; set; }
        public int? NumFactura { get; set; }
        public int? NumCorrelativo { get; set; }
        public int? TotalVenta { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTienda { get; set; }
        public DateTime? FechaVenta { get; set; }
    }
}
