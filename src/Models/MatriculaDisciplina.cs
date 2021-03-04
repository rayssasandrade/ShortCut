using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class MatriculaDisciplina
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status é obrigatório")]
        public bool Status { get; set; }

        public Aluno Aluno { get; set; }
        public int AlunoId { get; set; }

        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }

    }
}


        
    
