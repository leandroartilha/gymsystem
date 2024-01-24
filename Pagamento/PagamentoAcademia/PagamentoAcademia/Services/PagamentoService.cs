using System;
using PagamentoAcademia.Repositories;

namespace PagamentoAcademia.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoService(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public async Task UpdatePagamento(int id)
        {
            await _pagamentoRepository.EfetuarPagamento(id);
        }
    }
}

