
using LocadoraLucasFilmes.Models;
using LocadoraLucasFilmes.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace LocadoraLucasFilme.Controllers
{
    [Route("api/[Controller]")]
    public class tbFilmeController : Controller
    {
        private readonly IFilmesRepository _tbFilmesRepository;
        public tbFilmeController(IFilmesRepository filmeRep)
        {
            _tbFilmesRepository = filmeRep;
        }

        [HttpGet]
        public IEnumerable<tbFilmes> GetAll()
        {
            return _tbFilmesRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetFilmes")]
        public IActionResult GetById(long id)
        {
            var filme  = _tbFilmesRepository.Find(id);
            if (filme is null)
                return NotFound();

            return new ObjectResult(filme);
        }

        [HttpPost]
        public IActionResult Create([FromBody] tbFilmes filme)
        {
            if (filme is null)
                return BadRequest();

            _tbFilmesRepository.Add(filme);

            return CreatedAtRoute("GetFilmes", new { id = filme.id_Filme }, filme);
        }
    }
}
