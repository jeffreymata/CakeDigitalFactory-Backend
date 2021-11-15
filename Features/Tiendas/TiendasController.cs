using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Tiendas
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendasController : ControllerBase
    {
        private readonly TiendasService _tiendasService;


        public TiendasController(TiendasService tiendasService)
        {
            _tiendasService = tiendasService;
        }

        [HttpGet]
        [Route("get-tienda")]
        public ActionResult getTienda()
        {
            Result result =_tiendasService.getTienda();

            return Ok(result);
        }

        [HttpPost]
        [Route("post-tienda")]
        public ActionResult postTienda(TiendasDto request)
        {
            Result result = _tiendasService.CreateTienda(request);
            return Ok(result);
        }


    }
}
