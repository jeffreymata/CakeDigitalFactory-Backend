using CakeDigitalFactory.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Usuarios
{
    public class UsuariosService
    {
        private readonly CakeDigitalFactoryDBContext _dataContext;

        public UsuariosService(CakeDigitalFactoryDBContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Result CreateUsers(UsuariosDto request)
        {
            Usuario usuario = MaterializeUsuario(request);

            _dataContext.Add(usuario);
            _dataContext.SaveChanges();

            return new Result { Message = $"El usuario con la fecha {request.FechaCreacion} fue creado exitosamente" };
        }

        public Usuario MaterializeUsuario(UsuariosDto request)
        {
            Usuario newUsuario = new Usuario
            {
                Id = request.Id,
                Nombre = request.Nombre,
                UserName = request.UserName,
                Correo = request.Correo,
                FechaCreacion = request.FechaCreacion,
                Password = request.Password,
            };

            return newUsuario;
        }

    }
}
