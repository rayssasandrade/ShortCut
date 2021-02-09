using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class DisciplinaOfertada
    {
        [Key]
        public int Id { get; set; }

        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }

        public PeriodoLetivo PeriodoLetivo { get; set; }
        public int PeriodoLetivoId { get; set; }

        public virtual ICollection<Turma> Turmas { get; set; }
    }
}


        
    
