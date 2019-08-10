using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdAtleta { get; set; }
        public int IdEsporte { get; set; }
    }
}
