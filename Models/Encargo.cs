using System;
using System.Collections.Generic;

#nullable disable

namespace CakeDigitalFactory.Services.Models
{
    public partial class Encargo
    {
        public int Id { get; set; }
        public int? IdTienda { get; set; }
        public int? IdUsuario { get; set; }
        public string StatusOrden { get; set; }
        public DateTime? FechaEncargo { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaRecibido { get; set; }

        public void ActualizarEstadoAEnviado()
        {
            StatusOrden = "ENVIADO";
        }
    }
}
