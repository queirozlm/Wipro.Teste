using LocadoraLucasFilmes.Models;
using LocadoraLucasFilmes.Models.Context;
using LocadoraLucasFilmes.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Repository
{
    public class tbClienteRepository : IClienteRepository
    {
        private readonly ClienteDbContext _context;
        public tbClienteRepository(ClienteDbContext ctx)
        {
            _context = ctx;
        }
        public bool VerificarSeClienteExiste(string locador)
        {
            bool retorno;
            retorno = _context.tbCliente.Any(x => x.NomeCliente.Contains(locador));
            return retorno;
        }


     

        public void Add(tbCliente cliente)
        {
            
            bool nomeRetorno = VerificarSeClienteExiste(cliente.NomeCliente);

            if (nomeRetorno == false)
            {
                _context.tbCliente.Add(cliente);
                _context.SaveChanges();
                
            }
            else
            {

            }
        }

        public tbCliente Find(long id)
        {
            return _context.tbCliente.FirstOrDefault(u => u.id_Cliente == id);
        }   

        public tbCliente FindByName(string name)
        {
            return null;
        }

        public IEnumerable<tbCliente> GetAll()
        {
            return _context.tbCliente.ToList();
        }

        public void Update(tbCliente user)
        {
            
        }
    }
}
