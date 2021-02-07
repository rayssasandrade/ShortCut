using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class PreRequisitos
    {
        [Key]
        public int Id { get; set; }

        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }

        public Disciplina? PreRequisito { get; set; }
        public int PreRequisitoId { get; set; }
    }
}


        
    
