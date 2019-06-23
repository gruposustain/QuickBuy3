using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy3.Dominio.Entidades
{
    public abstract class Entidade
    {
        //private List<string> _mensagensValidacao { get; set; }
        private List<string> _mensagemValidacao
        {
            get { return new List<string>(); }
        }

        protected void AdicionarCritica(string mensagem)
        {
            _mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }

    }
}
