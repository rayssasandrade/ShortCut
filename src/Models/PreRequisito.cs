using System.ComponentModel.DataAnnotations;

namespace SisGerenciador.src.Models
{
    public class PreRequisito
    {
        [Key]
        public int Id { get; set; }

        public Disciplina DisciplinaRequerida { get; set; }
        public int DisciplinaRequeridaId { get; set; }
    }
}


