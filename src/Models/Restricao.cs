using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Restricao
    {
        [Key]
        public int Id { get; set; }

        public Aluno Aluno { get; set; }
        public int AlunoId { get; set; }

        public Horario Horario { get; set; }
        public int HorarioId { get; set; }

    }
}


        
    
