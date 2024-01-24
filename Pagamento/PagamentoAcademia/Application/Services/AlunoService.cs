using System;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Application.Services;
using System.Net.Http;

namespace Application.Services
{
    public class AlunoService : IAlunoService
    {
        [STAThread]
        static void Main()
        {
        }
        private IAlunoRepository _alunoRepository;
        //private object httpClient;
        //private object urlApiContagem;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task UpdateAlunoPagamento(int id)
        {
            var aluno = _alunoRepository.;
            

        }
    }
}

