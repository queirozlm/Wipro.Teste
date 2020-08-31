
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Models.Context
{
    public class FilmesDbContext : DbContext
    {
        public FilmesDbContext(DbContextOptions<FilmesDbContext> options) : base(options)
        {

        }
        public DbSet<tbFilmes> tbFilme { get; set; }
    }
}
