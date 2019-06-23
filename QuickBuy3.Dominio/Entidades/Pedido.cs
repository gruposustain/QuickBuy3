using QuickBuy3.Dominio.Entidades;
using QuickBuy3.Dominio.Entidades.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy3.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }


        //Dados do Item do Pedido
        public ICollection<ItemPedido> ItensPedido { get; set; }

        //Dados do Endeço de entrega
        public int EnderecoId { get; set; }
        public Endereco EnderecoEntrega { get; set; }


        //Dados da Forma de Pagamento
        public int FormaPagamentoId { get; set; }
        public FormaDePagamento FormaPagamento { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                AdicionarCritica("Erro - Nenhum item de pedido foi incluído!");
        }
    }
}
