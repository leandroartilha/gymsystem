using System;
using Domain.Entities;
using PagamentoAcademia.Context;

namespace PagamentoAcademia.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly ApplicationDbContext _context;

        public PagamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task EfetuarPagamento(int id)
        {
            var aluno = EncontrarAlunoById(id);
            aluno.Pago = true;
            _context.Update(aluno);
            await _context.SaveChangesAsync();
        }

        public Aluno EncontrarAlunoById(int id)
        {
            var aluno = _context.Alunos.Where(a => a.Id == id).FirstOrDefault();

            if (aluno != null)
            {
                return aluno;
            }
            return null;

        }
    }
}

