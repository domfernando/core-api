using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Models;
using CoreApi.Repository;
using Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using Core.Domain.Acesso;

namespace CoreApi.Controllers
{
    [Route("v1/usuario")]
    public class UsuarioController : Controller
    {
        private readonly Contexto _contexto;
        private readonly IMapper _mapper;

        public UsuarioController(Contexto contexto,
                                 IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var _users = await _contexto.Usuarios.ToListAsync();

                return Ok(_users != null ? _users : new List<Core.Domain.Acesso.Usuario>());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"ERROR {ex.Message}");
            }
        }

        [HttpPost]
        [Route("Criar")]
        public IActionResult Create([FromBody] UsuarioDTO usuario)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"ERROR {ex.Message}");
            }

            if (ModelState.IsValid)
            {
                var _usuario = _mapper.Map<Usuario>(usuario);
                _usuario.Travado = true;
                _usuario.Verificado = false;
                _usuario.Criado = System.DateTime.Now;

                _contexto.Add(_usuario);
                _contexto.SaveChanges();

                return Ok(usuario);
            }

            return BadRequest();            
        }
    }
}
