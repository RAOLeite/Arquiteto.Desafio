using Desafio.Lancamento.Infra.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Lancamento.Domain.Operacao.Commands.PersistirOperacao
{
    public abstract class PersistirOperacaoCommand : CommandBase
    {
        public PersistirOperacaoCommand(
                decimal _Valor,
                DateTime _DataOperacao,
                string _TipoOperacao,
                string _Descricao,
                string _Categoria,
                string _MetodoPagamento,
                Guid _ContaId,
                string _Moeda)
        {

            this.Valor = Valor;
            this.DataOperacao  = DataOperacao;
            this.TipoOperacao  = TipoOperacao;
            this.Descricao  = Descricao;
            this.MetodoPagamento  = MetodoPagamento;
            this.ContaId  = ContaId;
            this.Moeda  = Moeda;

        }

        protected PersistirOperacaoCommand()
        {
        }

        protected PersistirOperacaoCommand(
            decimal Valor,
            DateTime DataOperacao,
            string TipoOperacao,
            string Descricao,
            string MetodoPagamento,
            Guid ContaId,
            string Moeda)
        {
            this.Valor = Valor;
            this.DataOperacao  = DataOperacao;
            this.TipoOperacao  = TipoOperacao;
            this.Descricao  = Descricao;
            this.MetodoPagamento  = MetodoPagamento;
            this.ContaId  = ContaId;
            this.Moeda  = Moeda;
        }

        public decimal Valor { get; set; }
        public DateTime DataOperacao { get; set; }
        public string TipoOperacao { get; set; } // "Crédito" ou "Débito"
        public string Descricao { get; set; }
        public string MetodoPagamento { get; set; }
        public Guid ContaId { get; set; }
        public string Moeda { get; set; } // ex: "BRL", "USD"

    }
}




