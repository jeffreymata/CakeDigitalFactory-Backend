using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Encargos
{
    public class EncargoDto
    {
        public int Id { get; set; }
        public int IdTienda { get; set; }
        public int IdUsuario { get; set; }
        public string StatusOrden { get; set; }
        public DateTime FechaEncargo { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaRecibido { get; set; }
    }
}
