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

            return new Result { Message="Bienvenido" };
        }
    }
}
