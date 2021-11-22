using CakeDigitalFactory.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Login
{
  
    public class LoginServices
    {
        private readonly CakeDigitalFactoryDBContext _dataContext;

        public LoginServices(CakeDigitalFactoryDBContext dataContext)
        {
            _dataContext = dataContext;
        }


        public Result GetLoginValidation(string username, string password)
        {
            Usuario usuario = _dataContext.Usuarios.FirstOrDefault(x => x.UserName == username
            && x.Password == password);

            if (usuario == null)
            {
                return new Result { Message="Las credenciales son incorrectas" };
            }

            if (!string.IsNullOrWhiteSpace(usuario.UserName) && !string.IsNullOrWhiteSpace(usuario.Password))
            {

                return new Result { isActive = true };
            }
            return new Result { isActive = false };
        }

        public Result GetUserByName (string username)
        {
            Usuario usuario = _dataContext.Usuarios.FirstOrDefault(x => x.UserName == username);

            return new Result { Data = usuario };

        }


    }
}
