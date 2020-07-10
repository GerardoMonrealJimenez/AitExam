using Ait.Business;
using Ait.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Productos : ControllerBase
    {
        private readonly IProductBusiness productBusiness;

        public Productos(IProductBusiness productBusiness)
        {
            this.productBusiness = productBusiness;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> Get()
        {
            try
            {
                var response = await productBusiness.All();
                if (!response.Success) return this.StatusCode(StatusCodes.Status404NotFound);
                return response.Value.ToList();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
