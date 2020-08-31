using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLucasFilmes.Models
{
    public class tbFilmes
    {
        [Column("idFilme")]
        [Key]
        public int id_Filme { get; set; }

        [Column("nmFilme")]
        public string nm_Filme { get; set; }

        [Column("sitStatus")]
        public bool sit_Status { get; set; }

        [Column("retirado")]
        public DateTime reti_rado { get; set; }


    }
}
