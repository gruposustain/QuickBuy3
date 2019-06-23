using QuickBuy3.Dominio.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy3.Dominio.Entidades.ObjetosDeValor
{
    public class FormaDePagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamento.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito; }
        }

        public bool EhNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamento.NaoDefinido; }
        }
    }
}
