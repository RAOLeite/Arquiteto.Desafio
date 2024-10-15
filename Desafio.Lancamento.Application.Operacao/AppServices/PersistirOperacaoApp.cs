using Desafio.Lancamento.Application.Operacao.Contracts.Interfaces;
using Desafio.Lancamento.Application.Operacao.Contracts.ViewModel;
using Desafio.Lancamento.Domain.Operacao.Commands.PersistirOperacao;
using Desafio.Lancamento.Infra.Core.Commands;
using Desafio.Lancamento.Infra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Lancamento.Application.Operacao.AppServices
{
    public class PersistirOperacaoApp: IPersistirOperacaoApp
    {
        private readonly ICommandHandler<PersistirOperacaoCommand> _PersistirOperacaoCommandHandler;

        public PersistirOperacaoApp(ICommandHandler<PersistirOperacaoCommand> persistirOperacaoCommandHandler)
        {
            _PersistirOperacaoCommandHandler = persistirOperacaoCommandHandler;
        }

        public Result Validar(PersistirOperacaoViewModel model) => _PersistirOperacaoCommandHandler.Handle(new ValidarPersistirOperacaoCommand(model));


    }
}




