using Ait.Business;
using Ait.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Ait.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuarios : ControllerBase
    {
        private readonly IUserBusiness userBusiness;

        public Usuarios(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }

        [Route("Login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> Get(Users usuario)
        {
            try
            {
                var response = await userBusiness.Login(usuario.Nombre, usuario.Password);
                if (!response.Success) return this.StatusCode(StatusCodes.Status400BadRequest);
                return response.Value;
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
