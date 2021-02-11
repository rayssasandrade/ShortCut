using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisGerenciador.src.Models
{
    public class PreRequisito
    {
        [Key]
        public int Id { get; set; }

        public Disciplina Liberada { get; set; }
        public int LiberadaId { get; set; }

        public Disciplina Liberadora { get; set; }
        public int LiberadoraId { get; set; }
    }
}