using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P3.Models;
using P3.Services;

namespace P3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartinhasController : ControllerBase
    {
        private readonly ICartinhasService _service;

        public CartinhasController(ICartinhasService service)
        {
            _service = service;
        }

        [HttpGet("{nome}")]
        public async Task<IActionResult> Get(string nome)
        {
            var cartinha = _service.BuscarCartinha(nome, "Centro");
            if(cartinha == null)
            {
                return NotFound();
            }
            return Ok(cartinha);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cartinhas cartinha)
        {
            _service.InserirCartinha(cartinha);
            return Ok("Cartinha criado com sucesso");
        }
    }
}