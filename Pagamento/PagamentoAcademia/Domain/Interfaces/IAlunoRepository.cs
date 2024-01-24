using System;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Task<Aluno> UpdateAlunoPagamento(int id);
    }
}

