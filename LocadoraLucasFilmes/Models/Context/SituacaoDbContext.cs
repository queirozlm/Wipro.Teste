using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Models.Context
{
    public class SituacaoDbContext : DbContext
    {
        public SituacaoDbContext(DbContextOptions<FilmesDbContext> options) : base(options)
        {

        }
        public DbSet<tbSituacao> tbSituacaoo { get; set; }
    }
}
