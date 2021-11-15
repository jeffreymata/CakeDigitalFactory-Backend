using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Usuarios
{
    public class UsuariosDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UserName { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Password { get; set; }
    }
}
