using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Usuarios
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosService _usuariosService;


        public UsuariosController(UsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpPost]
        [Route("post-usuario")]
        public ActionResult postUsuario(UsuariosDto request)
        {
            Result result = _usuariosService.CreateUsers(request);
            return Ok(result);
        }

    }
}
