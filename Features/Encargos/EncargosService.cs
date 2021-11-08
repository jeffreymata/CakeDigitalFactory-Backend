using CakeDigitalFactory.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Encargos
{
    public class EncargosService
    {

        private readonly CakeDigitalFactoryDBContext _dataContext;

        public EncargosService(CakeDigitalFactoryDBContext dataContext)
        {
            _dataContext = dataContext;
        }


        public Result getEncargos()
        {
            IEnumerable<Encargo> encargos = _dataContext.Encargos;

            return new Result { Data = encargos };
        }

        public Result CreateEncargo(EncargoDto request)
        {
            Encargo encargo = MaterializeEncargo(request);

            _dataContext.Add(encargo);
            _dataContext.SaveChanges();

            return new Result { Message = $"El encargo con la fecha {request.FechaEncargo} fue creado exitosamente" };
        }

        public Result ActualizarEstatusDelEncargoEnviado(int encargoId)
        {
            Encargo encargo = _dataContext.Encargos.FirstOrDefault(x=>x.Id==encargoId);

            if (encargo == null)
            {
                return new Result { Message = "El encargo no existe" };
            }

            encargo.ActualizarEstadoAEnviado();

            _dataContext.SaveChanges();

            return new Result { Message = "El encargo fue actualizado con exito" };
        }


        public Encargo MaterializeEncargo(EncargoDto request)
        {
            Encargo newEncargo = new Encargo
            {
                IdTienda = request.IdTienda,
                IdUsuario = request.IdUsuario,
                StatusOrden = request.StatusOrden,
                FechaEncargo = request.FechaEncargo,
                FechaEnvio = request.FechaEnvio,
                FechaRecibido = request.FechaRecibido
            };

            return newEncargo;
        }

        public Result EliminarUnEncargo(int encargoId)
        {
            Encargo encargo = _dataContext.Encargos.FirstOrDefault(x=>x.Id == encargoId);

            if (encargo == null)
            {
                return new Result { Message = "el encargo que trata de eliminar no existe" };
            }

            _dataContext.Remove(encargo);
            _dataContext.SaveChanges();
            return new Result { Message = "El encargo se elimino con exito" };
        }
    }
}
