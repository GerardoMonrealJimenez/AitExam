using Ait.DataAccess.Repository;
using Ait.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IRepository<Users> repository;

        public UserBusiness(IRepository<Users> repository)
        {
            this.repository = repository;
        }

        public async Task<Response<bool>> Login(string nombre, string password)
        {
            var response = new Response<bool>();
            try
            {
                var usuario = await repository.Find(c => c.Nombre == nombre && c.Password == password);
                if (usuario == null) throw new ArgumentException($"El nombre o la contraseña no coinciden");
                response.SuccessResponse(true);
            }
            catch (Exception ex)
            {
                response.FailResponse(false, ex);
            }
            return response;
        }
    }
}
