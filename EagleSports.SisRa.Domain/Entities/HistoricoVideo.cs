using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class HistoricoVideo : RaEntity
    {
        public int Id { get; set; }
        public string UrlVideo { get; set; }
        public int IdAtleta { get; set; }
        public int IdEsporte { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(UrlVideo))
            {
                MensagemValidacao.Add("Url do video é obrigatório");
            }
            if (IdEsporte == 0)
            {
                MensagemValidacao.Add("É obrigatório selecionar um esporte");
            }
            if (IdAtleta == 0)
            {
                MensagemValidacao.Add("É obrigatório selecionar um atleta");
            }
        }
    }
}
