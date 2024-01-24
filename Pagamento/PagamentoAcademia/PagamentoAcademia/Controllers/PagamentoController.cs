using System;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using PagamentoAcademia.Services;

namespace PagamentoAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {

        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Pagar(int id)
        {
            await _pagamentoService.UpdatePagamento(id);

            return Ok($"Pagamento Efetuado!");
        }
    }
}

