using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Models
{
    public class tbCliente
    {
        [Column("idCliente")]
        [Key]
        public int id_Cliente { get; set; }

        [Column("Nome")]
        public string NomeCliente { get; set; }

    }
}
