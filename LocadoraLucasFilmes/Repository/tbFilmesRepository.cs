using LocadoraLucasFilmes.Models;
using LocadoraLucasFilmes.Models.Context;
using LocadoraLucasFilmes.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Repository
{
    public class tbFilmesRepository : IFilmesRepository
    {

        private readonly FilmesDbContext _context;
     

        public tbFilmesRepository(FilmesDbContext ctx)
        {
            _context = ctx;
        }
        public bool VerificarSeFilmeExiste(string video)
        {
            bool retorno;
            retorno = _context.tbFilme.Any(x => x.nm_Filme.Contains(video));
            return retorno;
        }

        public void add(tbSituacao Locacao)
        {
            throw new NotImplementedException();
        }

        public void Add(tbFilmes filme)
        {

            bool nomeRetorno = VerificarSeFilmeExiste(filme.nm_Filme);

            if (nomeRetorno == false)
            {
                filme.sit_Status = true;
                _context.tbFilme.Add(filme);
                _context.SaveChanges();

            }
            else
            {

            }

        }

        public tbFilmes Find(long id)
        {
            return _context.tbFilme.FirstOrDefault(u => u.id_Filme == id);
        }

        public tbFilmes FindByName(string name)
        {
            return null;
        }

        public IEnumerable<tbFilmes> GetAll()
        {
            return _context.tbFilme.ToList();
        }

        public void Update(tbFilmes user)
        {

        }

        
    }
}
