using LocadoraLucasFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Repository.Interface
{
    public interface IClienteRepository
    {
        void Add(tbCliente user);

        IEnumerable<tbCliente> GetAll();

        tbCliente Find(long id);

        void Update(tbCliente user);

        tbCliente FindByName(string name);
    }
}
