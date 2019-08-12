using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public class Atleta : RaEntity
    {
        public int Id { get; set; }
        public  string Nome { get; set; }
        public string Hastag { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }
        public string Equipe { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public string Skill { get; set; }
        public string Avaliador { get; set; }
        public string Telefone { get; set; }
        public ICollection<Esporte> IdEsporte { get; set; }
        public ICollection<Categoria> IdCategoria { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (String.IsNullOrEmpty(Nome))
                MensagemValidacao.Add("Campo nome é obrigatório");

            if (String.IsNullOrEmpty(Hastag))
                MensagemValidacao.Add("Campo hastag é obrigatório");

            if (String.IsNullOrEmpty(Email))
                MensagemValidacao.Add("Campo email é obrigatório");
        }

    }
}
