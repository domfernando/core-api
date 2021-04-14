using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Models;
using CoreApi.Repository;

namespace CoreApi.Controllers
{
    [Route("v1/usuario")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            var _users = UserRepo.Get();

            return _users;
        }
    }
}
