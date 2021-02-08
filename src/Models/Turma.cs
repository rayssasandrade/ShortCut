using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Turma
    {
        [Key]
        public int Id { get; set; }

        public DisciplinaOfertada DisciplinaOfertada { get; set; }
        public int DisciplinaOfertadaId { get; set; }

        public Docente Docente { get; set; }
        public int DocenteId { get; set; }

        public virtual ICollection<MatriculaTurma> MatriculasTurmas { get; set; }
        public virtual ICollection<SugestaoMatricula> SugestaoMatriculas { get; set; }
        public virtual ICollection<TurmaHorario> TurmaHorarios { get; set; }

    }
}


        
    
