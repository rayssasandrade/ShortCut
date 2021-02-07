using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class GradeCurricular
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatória", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "A descrição deve conter no mínimo 4 e máximo 255 caracteres.")]
        public string Descricao { get; set; }

        public Curso Curso { get; set; }
        public int CursoId { get; set; }

        public PeriodoCurricular PeriodoCurricular { get; set; }
        public int PeriodoCurricularId { get; set; }

        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }

    }
}
