using Ait.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Business
{
    public interface IUserBusiness
    {
        Task<Response<bool>> Login(string nombre, string password);
    }
}
