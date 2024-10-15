using Desafio.Lancamento.Domain.Operacao.Commands.PersistirOperacao;
using Desafio.Lancamento.Infra.Core.Commands;
using Desafio.Lancamento.Infra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Desafio.Lancamento.Domain.Operacao.Handlers.PersistirOperacao
{
    public class PersistirOperacaoHandler : CommandHandlerBase, ICommandHandler<PersistirOperacaoCommand>
    {
        public PersistirOperacaoHandler()
        {


        }

        public Result Handle(PersistirOperacaoCommand command)
        {
            
            var ehOK = true; //Gravação no banco de dados
            if (ehOK)
            {
                return new Result(true);
            }
            else
            {
                return new Result(false, new string[] {"Falha na Gravação"});
            }
        }
    }
}




