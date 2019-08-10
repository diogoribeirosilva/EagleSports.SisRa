using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class HistoricoVideo
    {
        public int Id { get; set; }
        public string UrlVideo { get; set; }
        public int IdAtleta { get; set; }
        public int IdEsporte { get; set; }

    }
}
