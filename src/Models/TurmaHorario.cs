using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class TurmaHorario
    {
        [Key]
        public int Id { get; set; }

        public HoraAula HoraAula { get; set; }
        public int HoraAulaId { get; set; }

        public Turma Turma { get; set; }
        public int TurmaId { get; set; }

    }
}
