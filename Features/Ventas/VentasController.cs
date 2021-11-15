using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Ventas
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly VentasService _ventasService;

        public VentasController(VentasService ventasService)
        {
            _ventasService = ventasService;
        }


        [HttpGet]
        [Route("get-ventas")]
        public ActionResult getVentas()
        {
            Result result = _ventasService.getVentas();

            return Ok(result);
        }

        [HttpPost]
        [Route("post-venta")]
        public ActionResult postVenta(VentasDto request)
        {
            Result result = _ventasService.CreateVenta(request);
            return Ok(result);
        }

    }
}
