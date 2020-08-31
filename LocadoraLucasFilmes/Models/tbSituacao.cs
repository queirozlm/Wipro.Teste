using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Models
{
    public class tbSituacao
    {
        [Column("Devolucao")]
        public DateTime Devo_lucao { get; set; }

    }
}
