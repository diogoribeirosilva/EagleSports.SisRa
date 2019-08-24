using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class Categoria : RaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AtletaId { get; set; }
        public virtual Atleta Atleta { get; set; }
        public int EsporteId { get; set; }
        public Esporte Esporte { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
