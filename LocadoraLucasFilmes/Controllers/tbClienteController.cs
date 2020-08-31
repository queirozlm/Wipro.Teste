using LocadoraLucasFilmes.Models;
using LocadoraLucasFilmes.Repository;
using LocadoraLucasFilmes.Repository.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace LocadoraLucasFilmes.Controllers
{
    [Route("api/[Controller]")]
    public class tbClienteController : Controller
    {
        private readonly IClienteRepository _tbClienteRepository;
        public tbClienteController(IClienteRepository clienteRep)
        {
            _tbClienteRepository = clienteRep;
        }

        [HttpGet]
        public IEnumerable<tbCliente> GetAll()
        {
            return _tbClienteRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetUsuario")]
        public IActionResult GetById(long id)
        {
            var cliente  = _tbClienteRepository.Find(id);
            if (cliente is null)
                return NotFound();

            return new ObjectResult(cliente);
        }

        [HttpPost]
        public IActionResult Create([FromBody] tbCliente cliente)
        {
            if (cliente is null)
                return BadRequest();

            _tbClienteRepository.Add(cliente);

            return CreatedAtRoute("GetUsuario", new { id = cliente.id_Cliente }, cliente);
        }
    }
}
