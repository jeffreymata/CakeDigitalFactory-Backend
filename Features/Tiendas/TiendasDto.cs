using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Tiendas
{
    public class TiendasDto
    {
        public int Id { get; set; }
        public string NombreTienda { get; set; }
        public string DireccionTienda { get; set; }
        public string CorreoTienda { get; set; }
        public string TelefonoTienda { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
