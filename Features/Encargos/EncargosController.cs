using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Encargos
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncargosController : ControllerBase
    {
        private readonly EncargosService _encargosService;


        public EncargosController(EncargosService encargosService)
        {
            _encargosService = encargosService;
        }


        [HttpGet]
        [Route("get-encargos")]
        public ActionResult getEncargos()
        {
            Result result = _encargosService.getEncargos();

            return Ok(result);
        }

        [HttpPost]
        [Route("post-encargo")]
        public ActionResult postEncargo(EncargoDto request)
        {
            Result result = _encargosService.CreateEncargo(request);
            return Ok(result);
        }

        [HttpPut]
        [Route("update-encargo")]
        public ActionResult ActualizarEncargo(EncargoDto request)
        {
            Result result = _encargosService.ActualizarEstatusDelEncargoEnviado(request.Id);

            return Ok(result);
        }

        [HttpDelete]
        [Route("delete-encargo")]
        public ActionResult EliminarEncargo(int encargoId)
        {
            Result result = _encargosService.EliminarUnEncargo(encargoId);
            return Ok(result);
        }
    }
}
