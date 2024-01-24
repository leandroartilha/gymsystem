using System;
using Domain.Entities;

namespace PagamentoAcademia.Repositories
{
    public interface IPagamentoRepository
    {
        public Aluno EncontrarAlunoById(int id);
        public Task EfetuarPagamento(int id);
    }
}