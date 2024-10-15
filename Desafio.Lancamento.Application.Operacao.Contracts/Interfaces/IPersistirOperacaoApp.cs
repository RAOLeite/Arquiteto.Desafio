using Desafio.Lancamento.Application.Operacao.Contracts.ViewModel;
using Desafio.Lancamento.Infra.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Lancamento.Application.Operacao.Contracts.Interfaces
{
    public interface IPersistirOperacaoApp
    {
        Result Validar(PersistirOperacaoViewModel plano);
    }
}




