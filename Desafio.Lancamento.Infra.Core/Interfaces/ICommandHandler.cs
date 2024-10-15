using Desafio.Lancamento.Infra.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Lancamento.Infra.Core.Interfaces
{
    public interface ICommandHandler<in T> where T : CommandBase
    {
        Result Handle(T command);
    }
}




