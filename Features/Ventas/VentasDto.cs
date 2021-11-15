using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Ventas
{
    public class VentasDto
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
