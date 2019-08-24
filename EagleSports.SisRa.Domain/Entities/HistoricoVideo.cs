using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class HistoricoVideo : RaEntity
    {
        public int Id { get; set; }
        public string UrlVideo { get; set; }
        public int AtletaId { get; set; }
        public virtual Atleta Atleta { get; set; }
        public int EsporteId { get; set; }
        public virtual Esporte Esporte { get; set; }
        public override void Validate()
        {
            if (String.IsNullOrEmpty(UrlVideo))
            {
                MensagemValidacao.Add("Url do video é obrigatório");
            }
            if (EsporteId == 0)
            {
                MensagemValidacao.Add("É obrigatório selecionar um esporte");
            }
            if (AtletaId == 0)
            {
                MensagemValidacao.Add("É obrigatório selecionar um atleta");
            }
        }
    }
}
