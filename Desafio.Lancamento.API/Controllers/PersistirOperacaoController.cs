using Desafio.Lancamento.Application.Operacao.Contracts.Interfaces;
using Desafio.Lancamento.Application.Operacao.Contracts.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Lancamento.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersistirOperacaoController : Controller
    {
        private readonly IPersistirOperacaoApp _PersistirOperacaoApp;
        private readonly ILogger<PersistirOperacaoController> _logger;

        public PersistirOperacaoController(ILogger<PersistirOperacaoController> logger, IPersistirOperacaoApp persistirOperacaoApp)
        {
            _logger = logger;
            _PersistirOperacaoApp = persistirOperacaoApp;
        }

        /// <summary>
        /// Posts the.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An ActionResult.</returns>
        [HttpPost]
        public ActionResult Post([FromBody] PersistirOperacaoViewModel value)
        {
            return new JsonResult(_PersistirOperacaoApp.Validar(value));
        }

    }
}




