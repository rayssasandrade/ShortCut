using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatória", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "A descrição deve conter no mínimo 4 e máximo 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Crédito")]
        public int Credito { get; set; }

        public virtual ICollection<DisciplinaOfertada> DisciplinaOfertadas { get; set; }
        
        public virtual ICollection<GradeCurricular> GradeCurriculares { get; set; }

        public virtual ICollection<MatriculaDisciplina> MatriculaDisciplinas { get; set; }
        public virtual ICollection<PreRequisito> Liberadas { get; set; }
        public virtual ICollection<PreRequisito> Liberadoras { get; set; }
    }
}
