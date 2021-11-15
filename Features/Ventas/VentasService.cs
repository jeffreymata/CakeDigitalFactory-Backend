using CakeDigitalFactory.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Ventas
{
    public class VentasService
    {
        private readonly CakeDigitalFactoryDBContext _dataContext;

        public VentasService(CakeDigitalFactoryDBContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Result CreateVenta(VentasDto request)
        {
            Venta venta = MaterializeVentas(request);

            _dataContext.Add(venta);
            _dataContext.SaveChanges();

            return new Result { Message = $"La venta con la fecha {request.FechaVenta} fue creada exitosamente" };
        }
        public Result getVentas()
        {
            IEnumerable<Venta> ventas = _dataContext.Ventas;

            return new Result { Data = ventas };
        }

        public Venta MaterializeVentas(VentasDto request)
        {
            Venta newVenta = new Venta
            {
                Id = request.Id,
                IdEncargo = request.IdEncargo,
                NumCai = request.NumCai,
                NumFactura = request.NumFactura,
                NumCorrelativo = request.NumCorrelativo,
                TotalVenta = request.TotalVenta,
                IdUsuario = request.IdUsuario,
                IdTienda = request.IdTienda,
                FechaVenta = request.FechaVenta
            };

            return newVenta;
        }

    }
}

