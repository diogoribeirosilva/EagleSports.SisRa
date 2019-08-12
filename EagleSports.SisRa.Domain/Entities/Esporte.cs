using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class Esporte : RaEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (String.IsNullOrEmpty(Nome))
            {
                MensagemValidacao.Add("Campo nome é obrigatório");
            }
        }
    }
}
