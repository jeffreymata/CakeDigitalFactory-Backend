using System;
using System.Collections.Generic;

#nullable disable

namespace CakeDigitalFactory.Services.Models
{
    public partial class Tienda
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
