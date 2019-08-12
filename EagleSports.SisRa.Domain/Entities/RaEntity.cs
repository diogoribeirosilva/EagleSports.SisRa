using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EagleSports.SisRa.Domain.Entities
{
    public abstract class RaEntity
    {
        public List<string> _mensagensValidacao { get; set; }

        protected List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        public abstract void Validate();
        protected bool EhValidado
        {
            get{ return !MensagemValidacao.Any(); }
        }
    }
}
