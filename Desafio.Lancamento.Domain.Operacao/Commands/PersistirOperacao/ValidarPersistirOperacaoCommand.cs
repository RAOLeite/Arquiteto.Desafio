using System;
using System.Collections.Generic;
using System.Text;
using Lancamento.Application;

namespace Desafio.Lancamento.Domain.Operacao.Commands.PersistirOperacao
{
    public class ValidarPersistirOperacaoCommand: PersistirOperacaoCommand
    {
        private Lancamento.Application.Operacao.Contracts.ViewModel.PersistirOperacaoViewModel model;
        private Lancamento.Application.Operacao.Contracts.ViewModel.PersistirOperacaoViewModel model1;

        public ValidarPersistirOperacaoCommand(Lancamento.Application.Operacao.Contracts.ViewModel.PersistirOperacaoViewModel model)
        {
            this.model = model;
        }

        public ValidarPersistirOperacaoCommand(Lancamento.Application.Operacao.Contracts.ViewModel.PersistirOperacaoViewModel model1)
        {
            this.model1 = model1;
        }

        public ValidarPersistirOperacaoCommand(
                decimal _Valor,
                DateTime _DataOperacao,
                string _TipoOperacao,
                string _Descricao,
                string _Categoria,
                string _MetodoPagamento,
                Guid _ContaId,
                string _Moeda) : base() { }
    }
}




