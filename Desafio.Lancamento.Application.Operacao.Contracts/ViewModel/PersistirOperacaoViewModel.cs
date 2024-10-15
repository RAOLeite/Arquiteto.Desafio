using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Lancamento.Application.Operacao.Contracts.ViewModel
{
    public class PersistirOperacaoViewModel
    {
        public decimal Valor { get; set; }
        public DateTime DataOperacao { get; set; }
        public string TipoOperacao { get; set; } // "Crédito" ou "Débito"
        public string Descricao { get; set; }
        public string MetodoPagamento { get; set; }
        public Guid ContaId { get; set; }
        public string Moeda { get; set; } // ex: "BRL", "USD"
    }
}




