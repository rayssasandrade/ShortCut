using System;

namespace SistemaGerenciadorDisciplinas.Models
{
    public class Docente
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set;
        public int Matricula { get; set; }
        public Date DtMatricula { get; set; }
        public Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }
    }
}
