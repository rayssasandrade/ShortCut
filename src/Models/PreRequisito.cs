using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class PreRequisito
    {
        [Key]
        public int Id { get; set; }

        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina DisciplinaRequeridas { get; set; }
        public int DisciplinaRequeridasId { get; set; }
    }
}


        
    
