using Desafio.Lancamento.Domain.Operacao.Contracts.Models;
using Desafio.Lancamento.Infra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Lancamento.Domain.Operacao.Contracts.Repositories
{
    public interface IPadraoRepository : IRepository<Padrao>
    {
        Task<bool> ExistsAsync(string name);
        Task<IEnumerable<Padrao>> GetAllAsync();

        //Padrao GetByFilter(string _campo1, string _campo2);
    }

}





