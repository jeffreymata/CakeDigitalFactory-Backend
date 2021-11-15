using CakeDigitalFactory.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Tiendas
{
    public class TiendasService
    {
        private readonly CakeDigitalFactoryDBContext _dataContext;

        public TiendasService(CakeDigitalFactoryDBContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Tienda MaterializeTienda(TiendasDto request)
        {
            Tienda newTienda = new Tienda
            {
                Id = request.Id,
                NombreTienda = request.NombreTienda,
                DireccionTienda = request.DireccionTienda,
                CorreoTienda = request.CorreoTienda,
                IdUsuario = request.IdUsuario,
                FechaCreacion = request.FechaCreacion
            };

            return newTienda;
        }
        public Result getTienda()
        {
            IEnumerable<Tienda> tiendas = _dataContext.Tienda;

            return new Result { Data = tiendas };
        }

        public Result CreateTienda(TiendasDto request)
        {
            Tienda tienda = MaterializeTienda(request);

            _dataContext.Add(tienda);
            _dataContext.SaveChanges();

            return new Result { Message = $"La tienda con la fecha {request.FechaCreacion} fue creada exitosamente" };
        }
    }
}
