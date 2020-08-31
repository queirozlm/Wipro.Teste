using LocadoraLucasFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Repository.Interface
{
    public interface IFilmesRepository
    {
        void Add(tbFilmes user);

        IEnumerable<tbFilmes> GetAll();

        tbFilmes Find(long id);

        void Update(tbFilmes user);

        tbFilmes FindByName(string name);
    }
}
