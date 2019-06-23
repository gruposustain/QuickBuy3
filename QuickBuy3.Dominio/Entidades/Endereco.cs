using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy3.Dominio.Entidades
{
    public class Endereco : Entidade
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("O CEP deve ser informado");

            if (string.IsNullOrEmpty(Estado))
                AdicionarCritica("O Estado deve ser preenchido");
        }
    }
}
