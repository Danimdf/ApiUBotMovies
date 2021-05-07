using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUBotMovies.Properties.Domain_Entity
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
    }
}
