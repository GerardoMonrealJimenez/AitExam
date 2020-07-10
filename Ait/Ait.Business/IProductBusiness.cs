using Ait.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Business
{
    public interface IProductBusiness
    {
        Task<Response<IEnumerable<Products>>> All();
    }
}
