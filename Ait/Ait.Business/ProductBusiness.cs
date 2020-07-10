using Ait.DataAccess.Repository;
using Ait.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IRepository<Products> repository;

        public ProductBusiness(IRepository<Products> repository)
        {
            this.repository = repository;
        }
        public async Task<Response<IEnumerable<Products>>> All()
        {
            var response = new Response<IEnumerable<Products>>();
            try
            {
                var productos = await repository.All();
                response.SuccessResponse(productos);
            }
            catch (Exception ex)
            {
                response.FailResponse(null, ex);
            }
            return response;
        }
    }
}
