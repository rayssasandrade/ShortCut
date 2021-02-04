using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }

    }
}
