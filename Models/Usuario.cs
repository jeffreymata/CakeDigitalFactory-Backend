using System;
using System.Collections.Generic;

#nullable disable

namespace CakeDigitalFactory.Services.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
