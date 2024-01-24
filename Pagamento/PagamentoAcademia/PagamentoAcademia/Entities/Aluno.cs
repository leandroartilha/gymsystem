using System;

namespace Domain.Entities
{
    public class Aluno
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string? Cpf { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string? Observacoes { get; private set; }
        public bool? Pago { get;  set; }

    }
}

